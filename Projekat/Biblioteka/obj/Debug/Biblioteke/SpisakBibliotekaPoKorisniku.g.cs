﻿#pragma checksum "..\..\..\Biblioteke\SpisakBibliotekaPoKorisniku.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "96D7D66C8590DE29D4465308A38ED8BBA71E3A9BBEC96E297F927C9AC9ADCD6A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Biblioteka.Biblioteke;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Biblioteka.Biblioteke {
    
    
    /// <summary>
    /// SpisakBibliotekaPoKorisniku
    /// </summary>
    public partial class SpisakBibliotekaPoKorisniku : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\Biblioteke\SpisakBibliotekaPoKorisniku.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label naslov;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Biblioteke\SpisakBibliotekaPoKorisniku.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pretraga;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Biblioteke\SpisakBibliotekaPoKorisniku.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridSveBiblioteke;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Biblioteka;component/biblioteke/spisakbibliotekapokorisniku.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Biblioteke\SpisakBibliotekaPoKorisniku.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.naslov = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.pretraga = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\..\Biblioteke\SpisakBibliotekaPoKorisniku.xaml"
            this.pretraga.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.pretraga_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dataGridSveBiblioteke = ((System.Windows.Controls.DataGrid)(target));
            
            #line 29 "..\..\..\Biblioteke\SpisakBibliotekaPoKorisniku.xaml"
            this.dataGridSveBiblioteke.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DataGridRow_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

