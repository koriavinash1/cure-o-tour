﻿#pragma checksum "C:\Users\avinash g kori\Desktop\heal-n-fun\heal_n_fun\heal_n_fun\workflowpage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E145DD8BCB9A6312FB876656BD927EE9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace heal_n_fun
{
    partial class workflowpage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 2:
                {
                    this.button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 12 "..\..\..\workflowpage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button).Click += this.button_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.button1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 13 "..\..\..\workflowpage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button1).Click += this.button1_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.button2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 5:
                {
                    this.button3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 6:
                {
                    this.button4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 16 "..\..\..\workflowpage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button4).Click += this.button4_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.button5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 17 "..\..\..\workflowpage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button5).Click += this.button5_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
