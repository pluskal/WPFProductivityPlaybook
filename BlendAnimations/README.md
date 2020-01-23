# BlendAnimations

1. Create new `Storyboard` called `WarningBounce`.
2. Create three entries resing the `image`.
3. Modify story board to decrease and restore the image size.
```XML
 <Storyboard x:Key="WarningBounce">
            <DoubleAnimationUsingKeyFrames Storyboard.TargetProperty="(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)" 
                                           Storyboard.TargetName="image"
                                           RepeatBehavior="0:0:2">
                <EasingDoubleKeyFrame KeyTime="0" Value="1"/>
                <EasingDoubleKeyFrame KeyTime="0:0:0.2" Value="0.7"/>
                <EasingDoubleKeyFrame KeyTime="0:0:0.4" Value="1"/>
            </DoubleAnimationUsingKeyFrames>
            <DoubleAnimationUsingKeyFrames Storyboard.TargetProperty="(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)" 
                                           Storyboard.TargetName="image"                                           
                                           RepeatBehavior="0:0:2">
                <EasingDoubleKeyFrame KeyTime="0" Value="1"/>
                <EasingDoubleKeyFrame KeyTime="0:0:0.2" Value="0.7"/>
                <EasingDoubleKeyFrame KeyTime="0:0:0.4" Value="1"/>
            </DoubleAnimationUsingKeyFrames>
        </Storyboard>
```
4. Run the application and observe the animation that **runs at startup** because of the implicit `trigger`.
```XML
    <Window.Triggers>
        <EventTrigger RoutedEvent="FrameworkElement.Loaded">
            <BeginStoryboard Storyboard="{StaticResource WarningBounce}"/>
        </EventTrigger>
    </Window.Triggers>
```
5. Use `ControlStoryboardAction` to run the animation on the image click. Drag and drop the behavior `ControlStoryboardAction` located in `Assets\Behaviors` onto the image in `Objects and Timeline` tab.
```XML
<b:Interaction.Triggers>
                <b:EventTrigger EventName="MouseLeftButtonDown">
                    <b:ControlStoryboardAction Storyboard="{StaticResource WarningBounce}"/>
                </b:EventTrigger>
            </b:Interaction.Triggers>
```