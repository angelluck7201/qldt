﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
using ComboBox = System.Windows.Forms.ComboBox;
using System.Drawing;

namespace QLDT.FormControls
{
    public class BaseUserControl : UserControl
    {
        public object ReturnObject;
        public List<Control> FormControls = new List<Control>();

        public void Init<T>(T data = null) where T : class
        {
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            FormControls = CRUD.GetAllChild(this);
            InitAction();
            if (data != null)
            {
                InitFormData(data);
            }
        }

        public void InitAction()
        {
            foreach (var control in FormControls)
            {
                if (control.Name == "btnSave")
                {
                    var featureName = this.Name.Replace("Uc", "");
                    if (Authorization.IsHavePermission(featureName, Define.PermissionEnum.Write.ToString()))
                    {
                        control.Click += new EventHandler(btnSave_Click);
                    }
                    else
                    {
                        control.Visible = false;
                    }
                }
                else if (control.Name == "btnCancel")
                {
                    control.Click += new EventHandler(btnCancel_Click);
                }
                else if (control.GetType().Name == "ImageEdit" || control.GetType().Name == "PictureEdit")
                {
                    //control.DoubleClick += new EventHandler(FileHelper.ShowImagePopup);
                }

                var controlType = control.GetType();
                if (controlType.Name == "ComboBox")
                {
                    var combobox = control as ComboBox;
                    if (combobox != null)
                    {
                        combobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        combobox.AutoCompleteSource = AutoCompleteSource.ListItems;
                    }
                }
            }
        }

        public void InitFormData(object data)
        {
            if (data != null)
            {
                var type = data.GetType();
                var modelName = type.Name.Split('_')[0];
                foreach (Control control in FormControls)
                {
                    var fieldName = control.Name.Split('_');
                    if (fieldName.Length <2 || !modelName.Equals(fieldName[0], StringComparison.OrdinalIgnoreCase)) continue;

                    var propertyName = "Text";
                    if (control is ComboBox)
                    {
                        propertyName = "SelectedValue";
                    }
                    if (control is TextEdit)
                    {
                        propertyName = "EditValue";
                    }

                    var prop = type.GetProperty(fieldName[1]);
                    if (prop != null) 
                    {
                        control.DataBindings.Add(new Binding(propertyName, data, fieldName[1]));
                    }
                    //var modelData = CRUD.ReflectionGet(data, fieldName);
                    //if (modelData != null)
                    //{
                    //    CRUD.SetControlValue(control, modelData);
                    //}
                }
            }
        }

        public virtual bool SaveData()
        {
            return true;
        }

        public virtual void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                CloseForm();
            }
        }

        public virtual void CloseForm()
        {
            var parentForm = this.ParentForm as DefaultForm;
            if (parentForm != null)
            {
                parentForm.ReturnObject = ReturnObject;
                parentForm.Close();
            }
        }

        public virtual void btnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
    }
}
