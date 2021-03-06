Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
Private Sub UserForm_Initialize()
        'Initialize each TextBox with a border style or special effect, 
        'and foreground and background colors 

        'TextBox1 initially uses a borderstyle 
        TextBox1.Text = "BorderStyle-Single"
        TextBox1.BorderStyle = fmBorderStyleSingle
        TextBox1.BorderColor = RGB(255, 128, 128)
        'Color - Salmon 
        TextBox1.ForeColor = RGB(255, 255, 0)
        'Color - Yellow 
        TextBox1.BackColor = RGB(0, 128, 64)
        'Color - Green #2 

        'TextBoxes 2 through 6 initially use special effects 
        TextBox2.Text = "Flat"
        TextBox2.SpecialEffect = fmSpecialEffectFlat
        TextBox2.ForeColor = RGB(64, 0, 0)
        'Color - Brown 
        TextBox2.BackColor = RGB(0, 0, 255)
        'Color - Blue 

        'Ensure the background style for TextBox2 is initially 
        'opaque. 
        TextBox2.BackStyle = fmBackStyleOpaque

        TextBox3.Text = "Etched"
        TextBox3.SpecialEffect = fmSpecialEffectEtched
        TextBox3.ForeColor = RGB(128, 0, 255)
        'Color - Purple 
        TextBox3.BackColor = RGB(0, 255, 255)
        'Color - Cyan 

        'Define BorderColor for later use (when borderstyle=fmBorderStyleSingle) 
        TextBox3.BorderColor = RGB(0, 0, 0)
        'Color - Black 

        TextBox4.Text = "Bump"
        TextBox4.SpecialEffect = fmSpecialEffectBump
        TextBox4.ForeColor = RGB(255, 0, 255)
        'Color - Magenta 
        TextBox4.BackColor = RGB(0, 0, 100)
        'Color - Navy blue 

        TextBox5.Text = "Raised"
        TextBox5.SpecialEffect = fmSpecialEffectRaised
        TextBox5.ForeColor = RGB(255, 0, 0)
        'Color - Red 
        TextBox5.BackColor = RGB(128, 128, 128)
        'Color - Gray 

        TextBox6.Text = "Sunken"
        TextBox6.SpecialEffect = fmSpecialEffectSunken
        TextBox6.ForeColor = RGB(0, 64, 0)
        'Color - Olive 
        TextBox6.BackColor = RGB(0, 255, 0)
        'Color - Green #1 

        ToggleButton1.Caption = "Swap styles"
        ToggleButton2.Caption = "Transparent/Opaque " _
 & "background"
    End Sub

    Private Sub ToggleButton1_Click()

        'Swap borders between TextBox1 and TextBox3 
        If ToggleButton1.Value = True Then
            'Change TextBox1 from BorderStyle to Etched 
            TextBox1.Text = "Etched"
            TextBox1.SpecialEffect = fmSpecialEffectEtched

            'Change TextBox3 from Etched to BorderStyle 
            TextBox3.Text = "BorderStyle-Single"
            TextBox3.BorderStyle = fmBorderStyleSingle
        Else
            'Change TextBox1 back to BorderStyle 
            TextBox1.Text = "BorderStyle-Single"
            TextBox1.BorderStyle = fmBorderStyleSingle

            'Change TextBox3 back to Etched 
            TextBox3.Text = "Etched"
            TextBox3.SpecialEffect = fmSpecialEffectEtched
        End If
    End Sub
    End Sub
End Class
