﻿#pragma checksum "..\..\..\..\..\Styles\Templates\HomeSetsVisual.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7D4622554E7FAE0A889F8D5F4473C58281DEA116"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Learn.Styles.Templates;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Learn.Styles.Templates {
    
    
    /// <summary>
    /// HomeSetsVisual
    /// </summary>
    public partial class HomeSetsVisual : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\..\Styles\Templates\HomeSetsVisual.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SetNameLB;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\Styles\Templates\HomeSetsVisual.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image favoriteBtnI;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\Styles\Templates\HomeSetsVisual.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CardNumLB;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Learn;component/styles/templates/homesetsvisual.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Styles\Templates\HomeSetsVisual.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.SetNameLB = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            
            #line 21 "..\..\..\..\..\Styles\Templates\HomeSetsVisual.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.bookmarkBtn_Click);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\..\..\Styles\Templates\HomeSetsVisual.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.favoriteBtn_MouseEnter);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\..\..\Styles\Templates\HomeSetsVisual.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.favoriteBtn_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 3:
            this.favoriteBtnI = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            
            #line 26 "..\..\..\..\..\Styles\Templates\HomeSetsVisual.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.HomeVis_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CardNumLB = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

