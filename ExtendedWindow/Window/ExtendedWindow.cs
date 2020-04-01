using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shell;

namespace ExtendedWindow
{
    public class ExtendedWindow : Window
    {
        /// <summary>
        /// 标识 FunctionBar 依赖属性。
        /// </summary>
        public static readonly DependencyProperty FunctionBarProperty =
            DependencyProperty.Register(nameof(FunctionBar), typeof(WindowFunctionBar), typeof(ExtendedWindow), new PropertyMetadata(default(WindowFunctionBar), OnFunctionBarChanged));

        public static readonly DependencyProperty TitleBarBackgroundProperty =
            DependencyProperty.Register(nameof(TitleBarBackground), typeof(Brush), typeof(ExtendedWindow), new PropertyMetadata());

        public static readonly DependencyProperty TitleBarForegroundProperty =
            DependencyProperty.Register(nameof(TitleBarForeground), typeof(Brush), typeof(ExtendedWindow), new PropertyMetadata());

        public ExtendedWindow()
        {
            DefaultStyleKey = typeof(ExtendedWindow);
        }

        /// <summary>
        /// 获取或设置FunctionBar的值
        /// </summary>
        public WindowFunctionBar FunctionBar
        {
            get => (WindowFunctionBar)GetValue(FunctionBarProperty);
            set => SetValue(FunctionBarProperty, value);
        }

        public Brush TitleBarBackground
        {
            get => (Brush)GetValue(TitleBarBackgroundProperty);
            set => SetValue(TitleBarBackgroundProperty, value);
        }

        public Brush TitleBarForeground
        {
            get => (Brush)GetValue(TitleBarForegroundProperty);
            set => SetValue(TitleBarForegroundProperty, value);
        }

        protected override void OnSourceInitialized(EventArgs e)
        {
            base.OnSourceInitialized(e);
            if (SizeToContent == SizeToContent.WidthAndHeight && WindowChrome.GetWindowChrome(this) != null)
            {
                InvalidateMeasure();
            }
        }

        /// <summary>
        /// FunctionBar 属性更改时调用此方法。
        /// </summary>
        /// <param name="oldValue">FunctionBar 属性的旧值。</param>
        /// <param name="newValue">FunctionBar 属性的新值。</param>
        protected virtual void OnFunctionBarChanged(WindowFunctionBar oldValue, WindowFunctionBar newValue)
        {
        }

        private static void OnFunctionBarChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var oldValue = (WindowFunctionBar)args.OldValue;
            var newValue = (WindowFunctionBar)args.NewValue;
            if (oldValue == newValue)
            {
                return;
            }

            var target = obj as ExtendedWindow;
            target?.OnFunctionBarChanged(oldValue, newValue);
        }
    }
}
