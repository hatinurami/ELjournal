﻿#pragma checksum "..\..\..\Windows\TeachWin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D005E74864A061800AF7A2262EF04A2B12F55E6840BFC6EA4685A9047A896C38"
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
    /// TeachWin
    /// </summary>
    public partial class TeachWin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\Windows\TeachWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TeachNameLab;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Windows\TeachWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lbJournal;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Windows\TeachWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbGroup;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\Windows\TeachWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Back;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Windows\TeachWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Next;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\Windows\TeachWin.xaml"
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
            System.Uri resourceLocater = new System.Uri("/ELjournal;component/windows/teachwin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\TeachWin.xaml"
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
            
            #line 12 "..\..\..\Windows\TeachWin.xaml"
            ((ELjournal.Windows.TeachWin)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TeachNameLab = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lbJournal = ((System.Windows.Controls.ListView)(target));
            
            #line 38 "..\..\..\Windows\TeachWin.xaml"
            this.lbJournal.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.lbJournal_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 39 "..\..\..\Windows\TeachWin.xaml"
            this.lbJournal.Loaded += new System.Windows.RoutedEventHandler(this.lbJournal_Loaded);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cbGroup = ((System.Windows.Controls.ComboBox)(target));
            
            #line 71 "..\..\..\Windows\TeachWin.xaml"
            this.cbGroup.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbGroup_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_Back = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\Windows\TeachWin.xaml"
            this.btn_Back.Click += new System.Windows.RoutedEventHandler(this.btn_Back_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_Next = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\Windows\TeachWin.xaml"
            this.btn_Next.Click += new System.Windows.RoutedEventHandler(this.btn_Next_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cb_NumItems = ((System.Windows.Controls.ComboBox)(target));
            
            #line 103 "..\..\..\Windows\TeachWin.xaml"
            this.cb_NumItems.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cb_NumItems_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

