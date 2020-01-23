# VisualState

1. Look at the source code, notice collapsed `ItemsControl` with `Height=0`. Expand it to `Height=60` to see the will be the expanded state.
2. Rotate the **Arrow** image to `-135` using mouse, and observe the resulting `RenderTransform`.
```XML
<Image.RenderTransform>
                <TransformGroup>
                    <ScaleTransform/>
                    <SkewTransform/>
                    <RotateTransform Angle="-135"/>
                    <TranslateTransform/>
                </TransformGroup>
            </Image.RenderTransform>
```
3. Add a new `StateGroup` called `ToolbarStates` in `States` tab.
   1. Create a new `state` clalled `Closed` and second one called `Open`.
   2. Select the `Open` state and use designer to rotate the arrow to `45` and set `ItemsControl` height to `60` using the `Properties` tab.
4. Drag&Drop the `CallMethodAction` behavior from `Assets\Behaviors` tab to the `Image` in the `Objects and Timeline` tab. 
   1. In properties of the `CallMethodAction` set the `TargetObject` to the `Window` in the designer.
   2. Use `ToggleIsState` as the `MethodName`.
   3. Create the `DependencyProperty` called `IsOpen` in the code-behind.
   ```csharp
    public bool IsOpen
        {
            get { return (bool)GetValue(IsOpenProperty); }
            set { SetValue(IsOpenProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsOpen.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsOpenProperty =
            DependencyProperty.Register("IsOpen", typeof(bool), typeof(MainWindow), new PropertyMetadata(false));
   ```
   4. Create the `ToggleIsOpen` method in the code-behind.
   ```csharp
   public void ToggleIsOpen()
        {
            IsOpen = !IsOpen;
        }
   ```
5. Drag&Drop `DataStateBehavior` onto the root `Grid`.
> You can also use `GoToStateAction` that is better in case that you use multiple states.
   1. Build the solution!
   2. In the properties of the `DataStateBehavior` select the wrench and set the `Binding` to the `Window` element int hte `Objects and Timeline`. And set `Property of Window` to the `IsOpen`.
   3. Set the `Value` to monitor to `True`.
   4. Set the `TrueState` to `Opened`.
   5. Set the `FalseState` to `Closed`.
   6. Run the application and click on the arrow button.
6. Set the `VisualState` transition `default transition` to be of type `Cubic` and transition time to `0.5s`.
