﻿#pragma checksum "..\..\..\Pages\DepartmentPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EA5D7FCD6897AA03F1BC8CE4A6D0D5244D97EF23F2A2378195E3C7B301F6C351"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PracticaKornilovaMarushkina.Pages;
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


namespace PracticaKornilovaMarushkina.Pages {
    
    
    /// <summary>
    /// DepartmentPage
    /// </summary>
    public partial class DepartmentPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Pages\DepartmentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SerchTb;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\DepartmentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Filtercb;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\DepartmentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView DList;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Pages\DepartmentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBtn;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Pages\DepartmentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteBtn;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Pages\DepartmentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeBtn;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Pages\DepartmentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CountDataTb;
        
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
            System.Uri resourceLocater = new System.Uri("/PracticaKornilovaMarushkina;component/pages/departmentpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\DepartmentPage.xaml"
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
            this.SerchTb = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\Pages\DepartmentPage.xaml"
            this.SerchTb.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SerchTb_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Filtercb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 21 "..\..\..\Pages\DepartmentPage.xaml"
            this.Filtercb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Filtercb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DList = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.AddBtn = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Pages\DepartmentPage.xaml"
            this.AddBtn.Click += new System.Windows.RoutedEventHandler(this.AddBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DeleteBtn = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Pages\DepartmentPage.xaml"
            this.DeleteBtn.Click += new System.Windows.RoutedEventHandler(this.DeleteBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ChangeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\Pages\DepartmentPage.xaml"
            this.ChangeBtn.Click += new System.Windows.RoutedEventHandler(this.ChangeBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CountDataTb = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

