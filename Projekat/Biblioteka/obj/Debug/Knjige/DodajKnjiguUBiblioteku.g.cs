#pragma checksum "..\..\..\Knjige\DodajKnjiguUBiblioteku.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "54C803727917410B22CFF5F3C6A7437F4A56A93F286FE80F2BD1F0709FFDD412"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Biblioteka.Knjige;
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


namespace Biblioteka.Knjige {
    
    
    /// <summary>
    /// DodajKnjiguUBiblioteku
    /// </summary>
    public partial class DodajKnjiguUBiblioteku : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Knjige\DodajKnjiguUBiblioteku.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridSveKnjige;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Knjige\DodajKnjiguUBiblioteku.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button izborKnjigeBtn;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Knjige\DodajKnjiguUBiblioteku.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridBiblioteke;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Knjige\DodajKnjiguUBiblioteku.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button dodajUBibliotekuBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Biblioteka;component/knjige/dodajknjiguubiblioteku.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Knjige\DodajKnjiguUBiblioteku.xaml"
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
            this.dataGridSveKnjige = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.izborKnjigeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\Knjige\DodajKnjiguUBiblioteku.xaml"
            this.izborKnjigeBtn.Click += new System.Windows.RoutedEventHandler(this.izborKnjigeBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dataGridBiblioteke = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.dodajUBibliotekuBtn = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\Knjige\DodajKnjiguUBiblioteku.xaml"
            this.dodajUBibliotekuBtn.Click += new System.Windows.RoutedEventHandler(this.dodajUBibliotekuBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

