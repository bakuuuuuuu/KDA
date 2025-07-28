using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace KDA.Views
{
    // SystemCommands를 사용하여 부모 Window와 상호작용
    public partial class WindowControlButtons : UserControl
    {
        // WindowControlButtons 컨트롤을 초기화하고, 창 조작을 위한 CommandBinding을 설정
        public WindowControlButtons()
        {
            InitializeComponent();

            // WPF에 내장된 표준 창 제어 명령(SystemCommands)과 실제 실행할 메서드를 연결
            this.CommandBindings.Add(new CommandBinding(SystemCommands.CloseWindowCommand, OnCloseWindow));
            this.CommandBindings.Add(new CommandBinding(SystemCommands.MaximizeWindowCommand, OnMaximizeWindow, OnCanResizeWindow));
            this.CommandBindings.Add(new CommandBinding(SystemCommands.MinimizeWindowCommand, OnMinimizeWindow, OnCanMinimizeWindow));
        }

        // 창 닫기
        private void OnCloseWindow(object sender, ExecutedRoutedEventArgs e)
        {
            Window.GetWindow(this).Close();
        }

        // 창 크기 최대화/복원
        private void OnMaximizeWindow(object sender, ExecutedRoutedEventArgs e)
        {
            var window = Window.GetWindow(this);
            window.WindowState = window.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
        }

        // 창 크기 최소화
        private void OnMinimizeWindow(object sender, ExecutedRoutedEventArgs e)
        {
            Window.GetWindow(this).WindowState = WindowState.Minimized;
        }

        // 최대화/복원 실행 가능 여부
        private void OnCanResizeWindow(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = Window.GetWindow(this).ResizeMode != ResizeMode.NoResize;
        }

        // 최소화 실행 가능 여부
        private void OnCanMinimizeWindow(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = Window.GetWindow(this).ResizeMode != ResizeMode.NoResize;
        }
    }
}