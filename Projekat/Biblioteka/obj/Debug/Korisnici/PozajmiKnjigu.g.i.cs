﻿#pragma checksum "..\..\..\Korisnici\PozajmiKnjigu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A7C45C0D1C78400C2EFE92A804DA47AFCEAAC45244960AA50EDB203B945198F1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Biblioteka.Korisnici;
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


namespace Biblioteka.Korisnici {
    
    
    /// <summary>
    /// PozajmiKnjigu
    /// </summary>
    public partial class PozajmiKnjigu : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\Korisnici\PozajmiKnjigu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridSviKorisnici;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Korisnici\PozajmiKnjigu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button izborKorisnikaBtn;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Korisnici\PozajmiKnjigu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridDostupneKnjige;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Korisnici\PozajmiKnjigu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pozajmiKnjiguBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Biblioteka;component/korisnici/pozajmiknjigu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Korisnici\PozajmiKnjigu.xaml"
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
            this.dataGridSviKorisnici = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.izborKorisnikaBtn = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Korisnici\PozajmiKnjigu.xaml"
            this.izborKorisnikaBtn.Click += new System.Windows.RoutedEventHandler(this.izborKorisnikaBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dataGridDostupneKnjige = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.pozajmiKnjiguBtn = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\Korisnici\PozajmiKnjigu.xaml"
            this.pozajmiKnjiguBtn.Click += new System.Windows.RoutedEventHandler(this.pozajmiKnjiguBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

