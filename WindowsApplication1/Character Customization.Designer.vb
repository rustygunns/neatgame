<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.grpPlayer = New System.Windows.Forms.GroupBox()
        Me.radZach = New System.Windows.Forms.RadioButton()
        Me.radAuggie = New System.Windows.Forms.RadioButton()
        Me.radJake = New System.Windows.Forms.RadioButton()
        Me.radDavid = New System.Windows.Forms.RadioButton()
        Me.radRyan = New System.Windows.Forms.RadioButton()
        Me.grpShirt = New System.Windows.Forms.GroupBox()
        Me.radOrangeShirt = New System.Windows.Forms.RadioButton()
        Me.radBlackShirt = New System.Windows.Forms.RadioButton()
        Me.radGreenShirt = New System.Windows.Forms.RadioButton()
        Me.radBlueShirt = New System.Windows.Forms.RadioButton()
        Me.radRedShirt = New System.Windows.Forms.RadioButton()
        Me.grpPants = New System.Windows.Forms.GroupBox()
        Me.radBluePants = New System.Windows.Forms.RadioButton()
        Me.radRedPants = New System.Windows.Forms.RadioButton()
        Me.radOrangePants = New System.Windows.Forms.RadioButton()
        Me.radGreenPants = New System.Windows.Forms.RadioButton()
        Me.radBlackPants = New System.Windows.Forms.RadioButton()
        Me.btnComplete = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.picAuggieRedRed = New System.Windows.Forms.PictureBox()
        Me.picDavidRedRed = New System.Windows.Forms.PictureBox()
        Me.picRyanRedRed = New System.Windows.Forms.PictureBox()
        Me.grpPlayer.SuspendLayout()
        Me.grpShirt.SuspendLayout()
        Me.grpPants.SuspendLayout()
        CType(Me.picAuggieRedRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDavidRedRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRyanRedRed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpPlayer
        '
        Me.grpPlayer.Controls.Add(Me.radZach)
        Me.grpPlayer.Controls.Add(Me.radAuggie)
        Me.grpPlayer.Controls.Add(Me.radJake)
        Me.grpPlayer.Controls.Add(Me.radDavid)
        Me.grpPlayer.Controls.Add(Me.radRyan)
        Me.grpPlayer.Location = New System.Drawing.Point(12, 12)
        Me.grpPlayer.Name = "grpPlayer"
        Me.grpPlayer.Size = New System.Drawing.Size(83, 138)
        Me.grpPlayer.TabIndex = 0
        Me.grpPlayer.TabStop = False
        Me.grpPlayer.Text = "Race"
        '
        'radZach
        '
        Me.radZach.AutoSize = True
        Me.radZach.Location = New System.Drawing.Point(6, 111)
        Me.radZach.Name = "radZach"
        Me.radZach.Size = New System.Drawing.Size(50, 17)
        Me.radZach.TabIndex = 1
        Me.radZach.TabStop = True
        Me.radZach.Text = "Zach"
        Me.radZach.UseVisualStyleBackColor = True
        '
        'radAuggie
        '
        Me.radAuggie.AutoSize = True
        Me.radAuggie.Location = New System.Drawing.Point(6, 88)
        Me.radAuggie.Name = "radAuggie"
        Me.radAuggie.Size = New System.Drawing.Size(58, 17)
        Me.radAuggie.TabIndex = 1
        Me.radAuggie.TabStop = True
        Me.radAuggie.Text = "Auggie"
        Me.radAuggie.UseVisualStyleBackColor = True
        '
        'radJake
        '
        Me.radJake.AutoSize = True
        Me.radJake.Location = New System.Drawing.Point(6, 65)
        Me.radJake.Name = "radJake"
        Me.radJake.Size = New System.Drawing.Size(48, 17)
        Me.radJake.TabIndex = 1
        Me.radJake.TabStop = True
        Me.radJake.Text = "Jake"
        Me.radJake.UseVisualStyleBackColor = True
        '
        'radDavid
        '
        Me.radDavid.AutoSize = True
        Me.radDavid.Location = New System.Drawing.Point(6, 42)
        Me.radDavid.Name = "radDavid"
        Me.radDavid.Size = New System.Drawing.Size(53, 17)
        Me.radDavid.TabIndex = 1
        Me.radDavid.TabStop = True
        Me.radDavid.Text = "David"
        Me.radDavid.UseVisualStyleBackColor = True
        '
        'radRyan
        '
        Me.radRyan.AutoSize = True
        Me.radRyan.Location = New System.Drawing.Point(6, 19)
        Me.radRyan.Name = "radRyan"
        Me.radRyan.Size = New System.Drawing.Size(50, 17)
        Me.radRyan.TabIndex = 1
        Me.radRyan.TabStop = True
        Me.radRyan.Text = "Ryan"
        Me.radRyan.UseVisualStyleBackColor = True
        '
        'grpShirt
        '
        Me.grpShirt.Controls.Add(Me.radOrangeShirt)
        Me.grpShirt.Controls.Add(Me.radBlackShirt)
        Me.grpShirt.Controls.Add(Me.radGreenShirt)
        Me.grpShirt.Controls.Add(Me.radBlueShirt)
        Me.grpShirt.Controls.Add(Me.radRedShirt)
        Me.grpShirt.Location = New System.Drawing.Point(101, 12)
        Me.grpShirt.Name = "grpShirt"
        Me.grpShirt.Size = New System.Drawing.Size(83, 138)
        Me.grpShirt.TabIndex = 1
        Me.grpShirt.TabStop = False
        Me.grpShirt.Text = "Shirt Color"
        '
        'radOrangeShirt
        '
        Me.radOrangeShirt.AutoSize = True
        Me.radOrangeShirt.Location = New System.Drawing.Point(7, 65)
        Me.radOrangeShirt.Name = "radOrangeShirt"
        Me.radOrangeShirt.Size = New System.Drawing.Size(60, 17)
        Me.radOrangeShirt.TabIndex = 4
        Me.radOrangeShirt.TabStop = True
        Me.radOrangeShirt.Text = "Orange"
        Me.radOrangeShirt.UseVisualStyleBackColor = True
        '
        'radBlackShirt
        '
        Me.radBlackShirt.AutoSize = True
        Me.radBlackShirt.Location = New System.Drawing.Point(6, 111)
        Me.radBlackShirt.Name = "radBlackShirt"
        Me.radBlackShirt.Size = New System.Drawing.Size(52, 17)
        Me.radBlackShirt.TabIndex = 3
        Me.radBlackShirt.TabStop = True
        Me.radBlackShirt.Text = "Black"
        Me.radBlackShirt.UseVisualStyleBackColor = True
        '
        'radGreenShirt
        '
        Me.radGreenShirt.AutoSize = True
        Me.radGreenShirt.Location = New System.Drawing.Point(6, 88)
        Me.radGreenShirt.Name = "radGreenShirt"
        Me.radGreenShirt.Size = New System.Drawing.Size(54, 17)
        Me.radGreenShirt.TabIndex = 2
        Me.radGreenShirt.TabStop = True
        Me.radGreenShirt.Text = "Green"
        Me.radGreenShirt.UseVisualStyleBackColor = True
        '
        'radBlueShirt
        '
        Me.radBlueShirt.AutoSize = True
        Me.radBlueShirt.Location = New System.Drawing.Point(6, 42)
        Me.radBlueShirt.Name = "radBlueShirt"
        Me.radBlueShirt.Size = New System.Drawing.Size(46, 17)
        Me.radBlueShirt.TabIndex = 2
        Me.radBlueShirt.TabStop = True
        Me.radBlueShirt.Text = "Blue"
        Me.radBlueShirt.UseVisualStyleBackColor = True
        '
        'radRedShirt
        '
        Me.radRedShirt.AutoSize = True
        Me.radRedShirt.Location = New System.Drawing.Point(6, 19)
        Me.radRedShirt.Name = "radRedShirt"
        Me.radRedShirt.Size = New System.Drawing.Size(45, 17)
        Me.radRedShirt.TabIndex = 2
        Me.radRedShirt.TabStop = True
        Me.radRedShirt.Text = "Red"
        Me.radRedShirt.UseVisualStyleBackColor = True
        '
        'grpPants
        '
        Me.grpPants.Controls.Add(Me.radBluePants)
        Me.grpPants.Controls.Add(Me.radRedPants)
        Me.grpPants.Controls.Add(Me.radOrangePants)
        Me.grpPants.Controls.Add(Me.radGreenPants)
        Me.grpPants.Controls.Add(Me.radBlackPants)
        Me.grpPants.Location = New System.Drawing.Point(190, 12)
        Me.grpPants.Name = "grpPants"
        Me.grpPants.Size = New System.Drawing.Size(83, 138)
        Me.grpPants.TabIndex = 2
        Me.grpPants.TabStop = False
        Me.grpPants.Text = "Pants Color"
        '
        'radBluePants
        '
        Me.radBluePants.AutoSize = True
        Me.radBluePants.Location = New System.Drawing.Point(6, 42)
        Me.radBluePants.Name = "radBluePants"
        Me.radBluePants.Size = New System.Drawing.Size(46, 17)
        Me.radBluePants.TabIndex = 1
        Me.radBluePants.TabStop = True
        Me.radBluePants.Text = "Blue"
        Me.radBluePants.UseVisualStyleBackColor = True
        '
        'radRedPants
        '
        Me.radRedPants.AutoSize = True
        Me.radRedPants.Location = New System.Drawing.Point(6, 19)
        Me.radRedPants.Name = "radRedPants"
        Me.radRedPants.Size = New System.Drawing.Size(45, 17)
        Me.radRedPants.TabIndex = 0
        Me.radRedPants.TabStop = True
        Me.radRedPants.Text = "Red"
        Me.radRedPants.UseVisualStyleBackColor = True
        '
        'radOrangePants
        '
        Me.radOrangePants.AutoSize = True
        Me.radOrangePants.Location = New System.Drawing.Point(6, 65)
        Me.radOrangePants.Name = "radOrangePants"
        Me.radOrangePants.Size = New System.Drawing.Size(60, 17)
        Me.radOrangePants.TabIndex = 6
        Me.radOrangePants.TabStop = True
        Me.radOrangePants.Text = "Orange"
        Me.radOrangePants.UseVisualStyleBackColor = True
        '
        'radGreenPants
        '
        Me.radGreenPants.AutoSize = True
        Me.radGreenPants.Location = New System.Drawing.Point(6, 88)
        Me.radGreenPants.Name = "radGreenPants"
        Me.radGreenPants.Size = New System.Drawing.Size(54, 17)
        Me.radGreenPants.TabIndex = 3
        Me.radGreenPants.TabStop = True
        Me.radGreenPants.Text = "Green"
        Me.radGreenPants.UseVisualStyleBackColor = True
        '
        'radBlackPants
        '
        Me.radBlackPants.AutoSize = True
        Me.radBlackPants.Location = New System.Drawing.Point(6, 111)
        Me.radBlackPants.Name = "radBlackPants"
        Me.radBlackPants.Size = New System.Drawing.Size(52, 17)
        Me.radBlackPants.TabIndex = 5
        Me.radBlackPants.TabStop = True
        Me.radBlackPants.Text = "Black"
        Me.radBlackPants.UseVisualStyleBackColor = True
        '
        'btnComplete
        '
        Me.btnComplete.Location = New System.Drawing.Point(517, 12)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(82, 37)
        Me.btnComplete.TabIndex = 4
        Me.btnComplete.Text = "&Complete"
        Me.btnComplete.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(517, 55)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 37)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblNote
        '
        Me.lblNote.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote.Location = New System.Drawing.Point(8, 153)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(300, 52)
        Me.lblNote.TabIndex = 6
        Me.lblNote.Text = "Note : Once you begin this journey, there's no going back."
        '
        'picAuggieRedRed
        '
        Me.picAuggieRedRed.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.picAuggieRedRed.Image = CType(resources.GetObject("picAuggieRedRed.Image"), System.Drawing.Image)
        Me.picAuggieRedRed.Location = New System.Drawing.Point(279, 12)
        Me.picAuggieRedRed.Name = "picAuggieRedRed"
        Me.picAuggieRedRed.Size = New System.Drawing.Size(140, 138)
        Me.picAuggieRedRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAuggieRedRed.TabIndex = 7
        Me.picAuggieRedRed.TabStop = False
        '
        'picDavidRedRed
        '
        Me.picDavidRedRed.Image = CType(resources.GetObject("picDavidRedRed.Image"), System.Drawing.Image)
        Me.picDavidRedRed.Location = New System.Drawing.Point(279, 12)
        Me.picDavidRedRed.Name = "picDavidRedRed"
        Me.picDavidRedRed.Size = New System.Drawing.Size(140, 138)
        Me.picDavidRedRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDavidRedRed.TabIndex = 8
        Me.picDavidRedRed.TabStop = False
        '
        'picRyanRedRed
        '
        Me.picRyanRedRed.Image = CType(resources.GetObject("picRyanRedRed.Image"), System.Drawing.Image)
        Me.picRyanRedRed.Location = New System.Drawing.Point(279, 12)
        Me.picRyanRedRed.Name = "picRyanRedRed"
        Me.picRyanRedRed.Size = New System.Drawing.Size(140, 138)
        Me.picRyanRedRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRyanRedRed.TabIndex = 9
        Me.picRyanRedRed.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(831, 402)
        Me.Controls.Add(Me.picRyanRedRed)
        Me.Controls.Add(Me.picDavidRedRed)
        Me.Controls.Add(Me.picAuggieRedRed)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnComplete)
        Me.Controls.Add(Me.grpPants)
        Me.Controls.Add(Me.grpShirt)
        Me.Controls.Add(Me.grpPlayer)
        Me.Name = "frmMain"
        Me.Text = "Character Customization"
        Me.grpPlayer.ResumeLayout(False)
        Me.grpPlayer.PerformLayout()
        Me.grpShirt.ResumeLayout(False)
        Me.grpShirt.PerformLayout()
        Me.grpPants.ResumeLayout(False)
        Me.grpPants.PerformLayout()
        CType(Me.picAuggieRedRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDavidRedRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRyanRedRed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpPlayer As System.Windows.Forms.GroupBox
    Friend WithEvents radZach As System.Windows.Forms.RadioButton
    Friend WithEvents radAuggie As System.Windows.Forms.RadioButton
    Friend WithEvents radJake As System.Windows.Forms.RadioButton
    Friend WithEvents radDavid As System.Windows.Forms.RadioButton
    Friend WithEvents radRyan As System.Windows.Forms.RadioButton
    Friend WithEvents grpShirt As System.Windows.Forms.GroupBox
    Friend WithEvents radGreenShirt As System.Windows.Forms.RadioButton
    Friend WithEvents radBlueShirt As System.Windows.Forms.RadioButton
    Friend WithEvents radRedShirt As System.Windows.Forms.RadioButton
    Friend WithEvents radOrangeShirt As System.Windows.Forms.RadioButton
    Friend WithEvents radBlackShirt As System.Windows.Forms.RadioButton
    Friend WithEvents grpPants As System.Windows.Forms.GroupBox
    Friend WithEvents radBluePants As System.Windows.Forms.RadioButton
    Friend WithEvents radRedPants As System.Windows.Forms.RadioButton
    Friend WithEvents radGreenPants As System.Windows.Forms.RadioButton
    Friend WithEvents radBlackPants As System.Windows.Forms.RadioButton
    Friend WithEvents radOrangePants As System.Windows.Forms.RadioButton
    Friend WithEvents btnComplete As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents picAuggieRedRed As System.Windows.Forms.PictureBox
    Friend WithEvents picDavidRedRed As System.Windows.Forms.PictureBox
    Friend WithEvents picRyanRedRed As System.Windows.Forms.PictureBox

End Class
