﻿#pragma checksum "..\..\SongElement.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D773D9981CDC432ECB3514F51F88ECAD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BukPlayer;
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


namespace BukPlayer {
    
    
    /// <summary>
    /// SongElement
    /// </summary>
    public partial class SongElement : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\SongElement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Title;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\SongElement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Artist;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\SongElement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\SongElement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image2;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\SongElement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label track;
        
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
            System.Uri resourceLocater = new System.Uri("/BukPlayer;component/songelement.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SongElement.xaml"
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
            
            #line 7 "..\..\SongElement.xaml"
            ((BukPlayer.SongElement)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.UserControl_MouseEnter);
            
            #line default
            #line hidden
            
            #line 7 "..\..\SongElement.xaml"
            ((BukPlayer.SongElement)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.UserControl_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Title = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.Artist = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.image = ((System.Windows.Controls.Image)(target));
            
            #line 19 "..\..\SongElement.xaml"
            this.image.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.image_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.image2 = ((System.Windows.Controls.Image)(target));
            
            #line 21 "..\..\SongElement.xaml"
            this.image2.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.image2_MouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.track = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
