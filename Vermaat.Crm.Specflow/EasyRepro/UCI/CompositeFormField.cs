﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Dynamics365.UIAutomation.Api;
using Microsoft.Dynamics365.UIAutomation.Browser;
using OpenQA.Selenium;

namespace Vermaat.Crm.Specflow.EasyRepro
{
    //class CompositeFormField : IFormField
    //{
    //    private List<FormFieldOld> _fields;

    //    public string FieldName { get; }

    //    public CompositeFormField(string parentField)
    //    {
    //        _fields = new List<FormFieldOld>();
    //        FieldName = parentField;
    //    }

    //    public void AddField(FormFieldOld field)
    //    {
    //        _fields.Add(field);
    //    }

    //    public bool IsOnForm(IWebDriver driver)
    //    {
    //        return Convert.ToBoolean(driver.ExecuteScript($"return Xrm.Page.getControl('{FieldName}') != null"));
    //    }

    //    public void EnterOnForm(IBrowser browser, IFormFiller formFiller)
    //    {
    //        formFiller.SetCompositeField(FieldName, _fields.Select(f => ( f.FieldName, (string)f.FieldValue) ));
    //    }
    //}
}