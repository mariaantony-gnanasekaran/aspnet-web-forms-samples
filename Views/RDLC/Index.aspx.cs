﻿using BoldReports.Models.ReportDesigner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReportsWebFormsSamples.Views.RDLC
{
    public partial class RDLC : Preview
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.designer.ToolbarSettings.Items = BoldReports.ReportDesignerEnums.ToolbarItems.All & ~BoldReports.ReportDesignerEnums.ToolbarItems.Save;
            this.designer.ReportItemExtensions = new List<ReportItemExtensionsModule>();
            this.designer.ReportItemExtensions.Add(new ReportItemExtensionsModule()
            {
                Name = "barcode",
                ClassName = "EJBarcode",
                ImageClass = "customitem-barcode",
                DisplayName = "1D Barcode",
                Category = "Barcodes"
            });
            this.designer.ReportItemExtensions.Add(new ReportItemExtensionsModule()
            {
                Name = "qrbarcode",
                ClassName = "EJQRBarcode",
                ImageClass = "customitem-qrbarcode",
                DisplayName = "QR Barcode",
                Category = "Barcodes"
            });

        }
    }
}