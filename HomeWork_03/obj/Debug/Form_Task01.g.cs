﻿#pragma checksum "..\..\Form_Task01.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4CA921DCD42299569CC2E3EF43CF4A42887B6A8D4D2AE61923F86B4D456BF7DF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using HomeWork_03;
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


namespace HomeWork_03 {
    
    
    /// <summary>
    /// Form_Task01
    /// </summary>
    public partial class Form_Task01 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\Form_Task01.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HomeWork_03.Form_Task01 Task01;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Form_Task01.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Image_Task01_image;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Form_Task01.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Lable_Task01_lable;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Form_Task01.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBox_Task01_filesDragNDrop;
        
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
            System.Uri resourceLocater = new System.Uri("/HomeWork_03;component/form_task01.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Form_Task01.xaml"
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
            this.Task01 = ((HomeWork_03.Form_Task01)(target));
            return;
            case 2:
            
            #line 14 "..\..\Form_Task01.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.Grid_MouseMove);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Image_Task01_image = ((System.Windows.Controls.Image)(target));
            
            #line 25 "..\..\Form_Task01.xaml"
            this.Image_Task01_image.DragEnter += new System.Windows.DragEventHandler(this.Image_Task01_image_DragEnter);
            
            #line default
            #line hidden
            
            #line 26 "..\..\Form_Task01.xaml"
            this.Image_Task01_image.Drop += new System.Windows.DragEventHandler(this.Image_Task01_image_Drop);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Lable_Task01_lable = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.listBox_Task01_filesDragNDrop = ((System.Windows.Controls.ListBox)(target));
            
            #line 38 "..\..\Form_Task01.xaml"
            this.listBox_Task01_filesDragNDrop.DragEnter += new System.Windows.DragEventHandler(this.listBox_Task01_filesDragNDrop_DragEnter);
            
            #line default
            #line hidden
            
            #line 39 "..\..\Form_Task01.xaml"
            this.listBox_Task01_filesDragNDrop.Drop += new System.Windows.DragEventHandler(this.listBox_Task01_filesDragNDrop_Drop);
            
            #line default
            #line hidden
            
            #line 40 "..\..\Form_Task01.xaml"
            this.listBox_Task01_filesDragNDrop.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.listBox_Task01_filesDragNDrop_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

