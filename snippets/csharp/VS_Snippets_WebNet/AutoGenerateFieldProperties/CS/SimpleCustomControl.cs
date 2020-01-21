﻿// <Snippet1>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Permissions;
using System.Web;

namespace Samples.AspNet.CS.Controls
{
      
    [AspNetHostingPermission(SecurityAction.Demand, Level=AspNetHostingPermissionLevel.Minimal)]
    [AspNetHostingPermission(SecurityAction.InheritanceDemand, Level=AspNetHostingPermissionLevel.Minimal)]
    public class SimpleCustomControl : DetailsView
    {

        protected override AutoGeneratedField CreateAutoGeneratedRow(AutoGeneratedFieldProperties fieldProperties) 
        {

            // Create an AutoGeneratedField object.
            AutoGeneratedField field = new AutoGeneratedField(fieldProperties.DataField);

            // Set the properties of the AutoGeneratedField using
            // the values from the AutoGeneratedFieldProperties 
            // object contained in the fieldProperties parameter.
            ((IStateManager)field).TrackViewState();
            field.HeaderText = fieldProperties.Name;
            field.SortExpression = fieldProperties.Name;
            field.ReadOnly = fieldProperties.IsReadOnly;
            field.DataType = fieldProperties.Type;

            return field;
        }
    }
}

// </Snippet1>
