﻿#pragma checksum "..\..\..\Windows\AdminWin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "999F2B03FD70BE0B2A9943C7641251F9143D379F116FB4333553EBBBED8F7EE5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ELjournal.Windows;
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


namespace ELjournal.Windows {
    
    
    /// <summary>
    /// AdminWin
    /// </summary>
    public partial class AdminWin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\Windows\AdminWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lb_Students;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Windows\AdminWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lb_Teachers;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Windows\AdminWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rb_Stud;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\Windows\AdminWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rb_Prep;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\Windows\AdminWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Add;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\Windows\AdminWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Del;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\Windows\AdminWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Edit;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\Windows\AdminWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Back;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\Windows\AdminWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Next;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\..\Windows\AdminWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_NumItems;
        
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
            System.Uri resourceLocater = new System.Uri("/ELjournal;component/windows/adminwin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\AdminWin.xaml"
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
            
            #line 33 "..\..\..\Windows\AdminWin.xaml"
            ((System.Windows.Controls.ListBox)(target)).Loaded += new System.Windows.RoutedEventHandler(this.ListBox_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lb_Students = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.lb_Teachers = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.rb_Stud = ((System.Windows.Controls.RadioButton)(target));
            
            #line 92 "..\..\..\Windows\AdminWin.xaml"
            this.rb_Stud.Click += new System.Windows.RoutedEventHandler(this.rb_Stud_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.rb_Prep = ((System.Windows.Controls.RadioButton)(target));
            
            #line 98 "..\..\..\Windows\AdminWin.xaml"
            this.rb_Prep.Click += new System.Windows.RoutedEventHandler(this.rb_Prep_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_Add = ((System.Windows.Controls.Button)(target));
            
            #line 109 "..\..\..\Windows\AdminWin.xaml"
            this.btn_Add.Click += new System.Windows.RoutedEventHandler(this.btn_Add_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_Del = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\..\Windows\AdminWin.xaml"
            this.btn_Del.Click += new System.Windows.RoutedEventHandler(this.btn_Del_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_Edit = ((System.Windows.Controls.Button)(target));
            
            #line 119 "..\..\..\Windows\AdminWin.xaml"
            this.btn_Edit.Click += new System.Windows.RoutedEventHandler(this.btn_Edit_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btn_Back = ((System.Windows.Controls.Button)(target));
            
            #line 128 "..\..\..\Windows\AdminWin.xaml"
            this.btn_Back.Click += new System.Windows.RoutedEventHandler(this.btn_Back_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btn_Next = ((System.Windows.Controls.Button)(target));
            
            #line 134 "..\..\..\Windows\AdminWin.xaml"
            this.btn_Next.Click += new System.Windows.RoutedEventHandler(this.btn_Next_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.cb_NumItems = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

