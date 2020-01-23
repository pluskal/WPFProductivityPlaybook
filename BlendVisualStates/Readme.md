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
