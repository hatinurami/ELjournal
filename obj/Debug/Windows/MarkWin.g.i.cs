﻿#pragma checksum "..\..\..\Windows\MarkWin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "05D5FBC597706EA54BB4172CD703571FBDB78D4BF86D797A5A29F7213623329E"
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
    /// MarkWin
    /// </summary>
    public partial class MarkWin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\Windows\MarkWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Windows\MarkWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox edGroup;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Windows\MarkWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel spStud;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Windows\MarkWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblStud;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Windows\MarkWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbStud;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Windows\MarkWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel spMrk;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Windows\MarkWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblMark;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Windows\MarkWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbMark;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Windows\MarkWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbx;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Windows\MarkWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveCh;
        
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
            System.Uri resourceLocater = new System.Uri("/ELjournal;component/windows/markwin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\MarkWin.xaml"
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
            
            #line 12 "..\..\..\Windows\MarkWin.xaml"
            ((ELjournal.Windows.MarkWin)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Exit = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Windows\MarkWin.xaml"
            this.Exit.Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.edGroup = ((System.Windows.Controls.ComboBox)(target));
            
            #line 43 "..\..\..\Windows\MarkWin.xaml"
            this.edGroup.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.edGroup_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.spStud = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.tblStud = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.cbStud = ((System.Windows.Controls.ComboBox)(target));
            
            #line 57 "..\..\..\Windows\MarkWin.xaml"
            this.cbStud.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbStud_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.spMrk = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.tblMark = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.cbMark = ((System.Windows.Controls.ComboBox)(target));
            
            #line 71 "..\..\..\Windows\MarkWin.xaml"
            this.cbMark.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbMark_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.tbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.saveCh = ((System.Windows.Controls.Button)(target));
            
            #line 88 "..\..\..\Windows\MarkWin.xaml"
            this.saveCh.Click += new System.Windows.RoutedEventHandler(this.saveCh_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

