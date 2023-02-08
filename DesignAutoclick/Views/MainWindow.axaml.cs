using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace DesignAutoclick.Views;

public partial class MainWindow : Window {
    
    private Point clickPosition;

    public Thickness SelectedImageMargin { get; set; } = new();

    private bool ButtonPressed = false;

    private Image SelectedImage;
    
    public MainWindow() {
        InitializeComponent();
    }
    
    
    private void HideButton_Click(object sender, RoutedEventArgs e) {
        this.WindowState = WindowState.Minimized;
    }

    private void CloseButton_Click(object sender, RoutedEventArgs e) {
        this.Close();
    }

    private void MaximizeButton_Click(object sender, RoutedEventArgs e) {
        if (this.WindowState == WindowState.Maximized)
        {
            this.WindowState = WindowState.Normal;
        }
        else
        {
            this.WindowState = WindowState.Maximized;
        }
    }


    private void Window_PointerPressed(object sender, PointerPressedEventArgs e) {
        if (e.GetCurrentPoint(this).Properties.IsLeftButtonPressed)
        {
            this.BeginMoveDrag(e);
        }
    }
    

    private void Slider_OnPointerPressed(object sender, PointerPressedEventArgs e) {
    }

    private void Slider_OnPointerReleased(object sender, PointerReleasedEventArgs e) {
        
    }

    private void Slider_PointerMoved(object sender, PointerEventArgs e) {
      
    }
    
}