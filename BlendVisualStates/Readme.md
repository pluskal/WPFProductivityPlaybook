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