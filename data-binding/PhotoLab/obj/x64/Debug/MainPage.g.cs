﻿#pragma checksum "\\Mac\Home\Desktop\Windows-appsample-photo-lab\xaml-basics-starting-points\data-binding\PhotoLab\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CAA743BAB24F002EC53E01338F8AE467A726ED20DA1524537A71BC307A01E539"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhotoLab
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_RatingControl_Value(global::Microsoft.UI.Xaml.Controls.RatingControl obj, global::System.Double value)
            {
                obj.Value = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MainPage_obj3_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::PhotoLab.ImageFileInfo dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj3;
            private global::Windows.UI.Xaml.Controls.Image obj4;
            private global::Windows.UI.Xaml.Controls.TextBlock obj5;
            private global::Microsoft.UI.Xaml.Controls.RatingControl obj6;
            private global::Windows.UI.Xaml.Controls.TextBlock obj7;
            private global::Windows.UI.Xaml.Controls.TextBlock obj8;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj4SourceDisabled = false;
            private static bool isobj5TextDisabled = false;
            private static bool isobj6ValueDisabled = false;
            private static bool isobj7TextDisabled = false;
            private static bool isobj8TextDisabled = false;

            public MainPage_obj3_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 77 && columnNumber == 21)
                {
                    isobj4SourceDisabled = true;
                }
                else if (lineNumber == 81 && columnNumber == 32)
                {
                    isobj5TextDisabled = true;
                }
                else if (lineNumber == 94 && columnNumber == 41)
                {
                    isobj6ValueDisabled = true;
                }
                else if (lineNumber == 86 && columnNumber == 36)
                {
                    isobj7TextDisabled = true;
                }
                else if (lineNumber == 89 && columnNumber == 36)
                {
                    isobj8TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3: // MainPage.xaml line 69
                        this.obj3 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.Grid)target);
                        break;
                    case 4: // MainPage.xaml line 76
                        this.obj4 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 5: // MainPage.xaml line 81
                        this.obj5 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 6: // MainPage.xaml line 94
                        this.obj6 = (global::Microsoft.UI.Xaml.Controls.RatingControl)target;
                        break;
                    case 7: // MainPage.xaml line 86
                        this.obj7 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 8: // MainPage.xaml line 89
                        this.obj8 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj3.Target as global::Windows.UI.Xaml.Controls.Grid).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::PhotoLab.ImageFileInfo) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::PhotoLab.ImageFileInfo)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::PhotoLab.ImageFileInfo obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ImageSource(obj.ImageSource, phase);
                        this.Update_ImageTitle(obj.ImageTitle, phase);
                        this.Update_ImageRating(obj.ImageRating, phase);
                        this.Update_ImageFileType(obj.ImageFileType, phase);
                        this.Update_ImageDimensions(obj.ImageDimensions, phase);
                    }
                }
            }
            private void Update_ImageSource(global::Windows.UI.Xaml.Media.Imaging.BitmapImage obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainPage.xaml line 76
                    if (!isobj4SourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj4, obj, null);
                    }
                }
            }
            private void Update_ImageTitle(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainPage.xaml line 81
                    if (!isobj5TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj5, obj, null);
                    }
                }
            }
            private void Update_ImageRating(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainPage.xaml line 94
                    if (!isobj6ValueDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_RatingControl_Value(this.obj6, obj);
                    }
                }
            }
            private void Update_ImageFileType(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainPage.xaml line 86
                    if (!isobj7TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj7, obj, null);
                    }
                }
            }
            private void Update_ImageDimensions(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainPage.xaml line 89
                    if (!isobj8TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj8, obj, null);
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MainPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::PhotoLab.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.GridView obj13;

            // Fields for each event bindings event handler.
            private global::Windows.UI.Xaml.RoutedEventHandler obj13Loaded;

            // Static fields for each binding's enabled/disabled state

            public MainPage_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 133 && columnNumber == 19)
                {
                    this.obj13.Loaded -= obj13Loaded;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 13: // MainPage.xaml line 126
                        this.obj13 = (global::Windows.UI.Xaml.Controls.GridView)target;
                        this.obj13Loaded = (global::System.Object p0, global::Windows.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            this.dataRoot.StartConnectedAnimationForBackNavigation();
                        };
                        ((global::Windows.UI.Xaml.Controls.GridView)target).Loaded += obj13Loaded;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::PhotoLab.MainPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::PhotoLab.MainPage obj, int phase)
            {
                if (obj != null)
                {
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // MainPage.xaml line 25
                {
                    this.page = (global::Windows.UI.Xaml.Controls.Page)(target);
                }
                break;
            case 9: // MainPage.xaml line 48
                {
                    this.ZoomSlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                }
                break;
            case 10: // MainPage.xaml line 56
                {
                    this.FitScreenToggle = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                }
                break;
            case 11: // MainPage.xaml line 111
                {
                    this.TitleTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // MainPage.xaml line 116
                {
                    this.MainCommandBar = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            case 13: // MainPage.xaml line 126
                {
                    this.ImageGridView = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // MainPage.xaml line 25
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MainPage_obj1_Bindings bindings = new MainPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            case 3: // MainPage.xaml line 69
                {                    
                    global::Windows.UI.Xaml.Controls.Grid element3 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    MainPage_obj3_Bindings bindings = new MainPage_obj3_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element3.DataContext);
                    element3.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element3, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element3, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

