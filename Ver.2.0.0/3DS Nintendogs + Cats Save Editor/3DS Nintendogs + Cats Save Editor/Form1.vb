Public Class Form1
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim Ownerpts = &H9C
    Dim Money = &HA0
    Dim Inventory = &HA4
    Dim houseinterior = &H207
    Dim Ist_animal = &H2AC
    Dim Ist_cat = &H4A2
    Dim Ist_dog = &H4AA
    Dim IInd_animal = &H1EAC
    Dim IInd_cat = &H20A2
    Dim IInd_dog = &H20AA
    Dim IIIrd_animal = &H3AAC
    Dim IIIrd_cat = &H3CA2
    Dim IIIrd_dog = &H3CAA
    Dim IVth_animal = &H56AC
    Dim IVth_cat = &H58A2
    Dim IVth_dog = &H58AA
    Dim Vth_animal = &H72AC
    Dim Vth_cat = &H74A2
    Dim Vth_dog = &H74AA
    Dim VIth_animal = &H8EAC
    Dim VIth_cat = &H90A2
    Dim VIth_dog = &H90AA

    Private Sub Closebutton_Click(sender As Object, e As EventArgs) Handles Closebutton.Click
        Me.Close()
    End Sub

    Private Sub Closebutton_MouseMove(sender As Object, e As EventArgs) Handles Closebutton.MouseMove
        Closebutton.Image = My.Resources.close_red
    End Sub

    Private Sub Closebutton_MouseLeave(sender As Object, e As EventArgs) Handles Closebutton.MouseLeave
        Closebutton.Image = My.Resources.close
    End Sub

    Private Sub TLSE_header_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TLSE_header.MouseDown, TLSE_title.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = True
            MousedwnX = e.X
            MousedwnY = e.Y
        End If
    End Sub

    Private Sub TLSE_header_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TLSE_header.MouseUp, TLSE_title.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub TLSE_header_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TLSE_header.MouseMove, TLSE_title.MouseMove
        If IsFormBeingDragged = True Then
            Dim tmp As Point = New Point()
            tmp.X = Me.Location.X + (e.X - MousedwnX)
            tmp.Y = Me.Location.Y + (e.Y - MousedwnY)
            Me.Location = tmp
            tmp = Nothing
        End If
    End Sub

    Private Sub Minimizebutton_Click(sender As Object, e As EventArgs) Handles Minimizebutton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Minimizebutton_MouseMove(sender As Object, e As MouseEventArgs) Handles Minimizebutton.MouseMove
        Minimizebutton.Image = My.Resources.minimize_gray
    End Sub

    Private Sub Minimizebutton_MouseLeave(sender As Object, e As EventArgs) Handles Minimizebutton.MouseLeave
        Minimizebutton.Image = My.Resources.minimize
    End Sub

    Private Sub Icon_MiitopiaSE_Click(sender As Object, e As EventArgs) Handles Icon_MiitopiaSE.Click
        Process.Start("https://github.com/Brionjv/Miitopia-Save-Editor/releases")
    End Sub

    Private Sub Icon_MiitopiaSE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_MiitopiaSE.MouseLeave
        Icon_MiitopiaSE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_MiitopiaSE_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_MiitopiaSE.MouseMove
        Icon_MiitopiaSE.BorderStyle = BorderStyle.FixedSingle
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try Miitopia Save Editor"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour télécharger et essayer Miitopia Save Editor"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_ChibiRoboZLSE_Click(sender As Object, e As EventArgs) Handles Icon_ChibiRoboZLSE.Click
        Process.Start("https://github.com/Brionjv/Chibi-Robo-ZL-Save-Editor/releases")
    End Sub

    Private Sub Icon_ChibiRoboZLSE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_ChibiRoboZLSE.MouseLeave
        Icon_ChibiRoboZLSE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_ChibiRoboZLSE_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_ChibiRoboZLSE.MouseMove
        Icon_ChibiRoboZLSE.BorderStyle = BorderStyle.FixedSingle
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try Chibi Robo zip Lash Save Editor"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour télécharger et essayer Chibi Robo zip Lash Save Editor"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_PaparMarioSSSE_Click(sender As Object, e As EventArgs) Handles Icon_PaparMarioSSSE.Click
        Process.Start("https://github.com/Brionjv/Paper-Mario-SS-Save-Editor/releases")
    End Sub

    Private Sub Icon_PaparMarioSSSE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_PaparMarioSSSE.MouseLeave
        Icon_PaparMarioSSSE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_PaparMarioSSSE_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_PaparMarioSSSE.MouseMove
        Icon_PaparMarioSSSE.BorderStyle = BorderStyle.FixedSingle
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try Paper Mario Sticker Star Save Editor"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour télécharger et essayer Paper Mario Sticker Star Save Editor"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_IronfallISE_Click(sender As Object, e As EventArgs) Handles Icon_IronfallISE.Click
        Process.Start("https://github.com/Brionjv/Ironfall-Invasion-Save-Editor/releases")
    End Sub

    Private Sub Icon_IronfallISE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_IronfallISE.MouseLeave
        Icon_IronfallISE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_IronfallISE_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_IronfallISE.MouseMove
        Icon_IronfallISE.BorderStyle = BorderStyle.FixedSingle
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try Ironfall Invasion Save Editor"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour télécharger et essayer Ironfall Invasion Save Editor"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_MarioPartyITSE_Click(sender As Object, e As EventArgs) Handles Icon_MarioPartyITSE.Click
        Process.Start("https://github.com/Brionjv/Mario-Party-IT-Save-Editor/releases")
    End Sub

    Private Sub Icon_MarioPartyITSE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_MarioPartyITSE.MouseLeave
        Icon_MarioPartyITSE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_MarioPartyITSE_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_MarioPartyITSE.MouseMove
        Icon_MarioPartyITSE.BorderStyle = BorderStyle.FixedSingle
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try Mario Party Island Tour Save Editor"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour télécharger et essayer Mario Party Island Tour Save Editor"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_3dsSEL_Click(sender As Object, e As EventArgs) Handles Icon_3dsSEL.Click
        Process.Start("https://github.com/Brionjv/3DS-Save-Editors-Library/releases")
    End Sub

    Private Sub Icon_3dsSEL_MouseLeave(sender As Object, e As EventArgs) Handles Icon_3dsSEL.MouseLeave
        Icon_3dsSEL.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_3dsSEL_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_3dsSEL.MouseMove
        Icon_3dsSEL.BorderStyle = BorderStyle.FixedSingle
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_description.Text = "Click to download and try 3DS Save Editors Library (Collection of little save editors)"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_description.Text = "Cliquez pour télécharger et essayer 3DS Save Editors Library (Collection de petit éditeurs de sauvegarde)"
        End If
        Panel_description.Visible = True
    End Sub

    Private Sub Text_OtherSE_Click(sender As Object, e As EventArgs) Handles Text_OtherSE.Click
        Process.Start("https://github.com/Brionjv?tab=repositories")
    End Sub


End Class
