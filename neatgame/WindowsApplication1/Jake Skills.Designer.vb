<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJakeSkills
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
        Me.grpRacialBuffs = New System.Windows.Forms.GroupBox()
        Me.lblBeardOfDreams = New System.Windows.Forms.Label()
        Me.lblTravelersGallop = New System.Windows.Forms.Label()
        Me.lblLuckyTalisman = New System.Windows.Forms.Label()
        Me.lblFireRate = New System.Windows.Forms.Label()
        Me.grpUltimate = New System.Windows.Forms.GroupBox()
        Me.lblSmashDescription = New System.Windows.Forms.Label()
        Me.lblStrikeDescription = New System.Windows.Forms.Label()
        Me.radJakeSmash = New System.Windows.Forms.RadioButton()
        Me.radAncerstralStrike = New System.Windows.Forms.RadioButton()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.lblLore = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.grpRacialBuffs.SuspendLayout()
        Me.grpUltimate.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpRacialBuffs
        '
        Me.grpRacialBuffs.Controls.Add(Me.lblBeardOfDreams)
        Me.grpRacialBuffs.Controls.Add(Me.lblTravelersGallop)
        Me.grpRacialBuffs.Controls.Add(Me.lblLuckyTalisman)
        Me.grpRacialBuffs.Controls.Add(Me.lblFireRate)
        Me.grpRacialBuffs.Location = New System.Drawing.Point(12, 12)
        Me.grpRacialBuffs.Name = "grpRacialBuffs"
        Me.grpRacialBuffs.Size = New System.Drawing.Size(272, 238)
        Me.grpRacialBuffs.TabIndex = 0
        Me.grpRacialBuffs.TabStop = False
        Me.grpRacialBuffs.Text = "Racial Buffs"
        '
        'lblBeardOfDreams
        '
        Me.lblBeardOfDreams.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeardOfDreams.Location = New System.Drawing.Point(6, 175)
        Me.lblBeardOfDreams.Name = "lblBeardOfDreams"
        Me.lblBeardOfDreams.Size = New System.Drawing.Size(263, 56)
        Me.lblBeardOfDreams.TabIndex = 3
        Me.lblBeardOfDreams.Text = "Beard of Dreams : Jake's amazing facial hair casues him to inflict 5% damage back" & _
    " to his enemies when hit."
        '
        'lblTravelersGallop
        '
        Me.lblTravelersGallop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTravelersGallop.Location = New System.Drawing.Point(6, 119)
        Me.lblTravelersGallop.Name = "lblTravelersGallop"
        Me.lblTravelersGallop.Size = New System.Drawing.Size(263, 56)
        Me.lblTravelersGallop.TabIndex = 2
        Me.lblTravelersGallop.Text = "Travelers Gallop : Jake spent his young years training to be a runner giving him " & _
    "5% extra movement speed."
        '
        'lblLuckyTalisman
        '
        Me.lblLuckyTalisman.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLuckyTalisman.Location = New System.Drawing.Point(6, 61)
        Me.lblLuckyTalisman.Name = "lblLuckyTalisman"
        Me.lblLuckyTalisman.Size = New System.Drawing.Size(263, 58)
        Me.lblLuckyTalisman.TabIndex = 1
        Me.lblLuckyTalisman.Text = "Lucky Talisman : Jake wears his silver chain causing him to dodge 10% more attack" & _
    "s."
        '
        'lblFireRate
        '
        Me.lblFireRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFireRate.Location = New System.Drawing.Point(6, 16)
        Me.lblFireRate.Name = "lblFireRate"
        Me.lblFireRate.Size = New System.Drawing.Size(263, 45)
        Me.lblFireRate.TabIndex = 0
        Me.lblFireRate.Text = "Fire Rate : Jake polishes his bow and begins to shoot 35% faster."
        '
        'grpUltimate
        '
        Me.grpUltimate.Controls.Add(Me.lblSmashDescription)
        Me.grpUltimate.Controls.Add(Me.lblStrikeDescription)
        Me.grpUltimate.Controls.Add(Me.radJakeSmash)
        Me.grpUltimate.Controls.Add(Me.radAncerstralStrike)
        Me.grpUltimate.Location = New System.Drawing.Point(290, 12)
        Me.grpUltimate.Name = "grpUltimate"
        Me.grpUltimate.Size = New System.Drawing.Size(280, 137)
        Me.grpUltimate.TabIndex = 1
        Me.grpUltimate.TabStop = False
        Me.grpUltimate.Text = "Choose Ultimate Ability"
        '
        'lblSmashDescription
        '
        Me.lblSmashDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSmashDescription.Location = New System.Drawing.Point(151, 39)
        Me.lblSmashDescription.Name = "lblSmashDescription"
        Me.lblSmashDescription.Size = New System.Drawing.Size(123, 86)
        Me.lblSmashDescription.TabIndex = 3
        Me.lblSmashDescription.Text = "Jake gathers his strength smashing his opponents head stunning him for 3 turns. G" & _
    "ains fatigue for 1 turn"
        '
        'lblStrikeDescription
        '
        Me.lblStrikeDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrikeDescription.Location = New System.Drawing.Point(6, 39)
        Me.lblStrikeDescription.Name = "lblStrikeDescription"
        Me.lblStrikeDescription.Size = New System.Drawing.Size(123, 75)
        Me.lblStrikeDescription.TabIndex = 2
        Me.lblStrikeDescription.Text = "Jake calls upon his ancestors and all strike together dealing 400% attack damage." & _
    ""
        '
        'radJakeSmash
        '
        Me.radJakeSmash.AutoSize = True
        Me.radJakeSmash.Location = New System.Drawing.Point(154, 19)
        Me.radJakeSmash.Name = "radJakeSmash"
        Me.radJakeSmash.Size = New System.Drawing.Size(83, 17)
        Me.radJakeSmash.TabIndex = 1
        Me.radJakeSmash.TabStop = True
        Me.radJakeSmash.Text = "Jake Smash"
        Me.radJakeSmash.UseVisualStyleBackColor = True
        '
        'radAncerstralStrike
        '
        Me.radAncerstralStrike.AutoSize = True
        Me.radAncerstralStrike.Location = New System.Drawing.Point(6, 19)
        Me.radAncerstralStrike.Name = "radAncerstralStrike"
        Me.radAncerstralStrike.Size = New System.Drawing.Size(99, 17)
        Me.radAncerstralStrike.TabIndex = 0
        Me.radAncerstralStrike.TabStop = True
        Me.radAncerstralStrike.Text = "Ancestral Strike"
        Me.radAncerstralStrike.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(290, 155)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(80, 39)
        Me.btnContinue.TabIndex = 2
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'lblLore
        '
        Me.lblLore.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLore.Location = New System.Drawing.Point(376, 155)
        Me.lblLore.Name = "lblLore"
        Me.lblLore.Size = New System.Drawing.Size(194, 132)
        Me.lblLore.TabIndex = 3
        Me.lblLore.Text = "Click this button to begin your adventure to stop the evil lord Tanner from devas" & _
    "tating The Isles Of Dew"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(290, 200)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(80, 39)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmJakeSkills
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 296)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblLore)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.grpUltimate)
        Me.Controls.Add(Me.grpRacialBuffs)
        Me.Name = "frmJakeSkills"
        Me.Text = "Jake Skills"
        Me.grpRacialBuffs.ResumeLayout(False)
        Me.grpUltimate.ResumeLayout(False)
        Me.grpUltimate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpRacialBuffs As System.Windows.Forms.GroupBox
    Friend WithEvents lblFireRate As System.Windows.Forms.Label
    Friend WithEvents lblBeardOfDreams As System.Windows.Forms.Label
    Friend WithEvents lblTravelersGallop As System.Windows.Forms.Label
    Friend WithEvents lblLuckyTalisman As System.Windows.Forms.Label
    Friend WithEvents grpUltimate As System.Windows.Forms.GroupBox
    Friend WithEvents radAncerstralStrike As System.Windows.Forms.RadioButton
    Friend WithEvents lblStrikeDescription As System.Windows.Forms.Label
    Friend WithEvents radJakeSmash As System.Windows.Forms.RadioButton
    Friend WithEvents lblSmashDescription As System.Windows.Forms.Label
    Friend WithEvents btnContinue As System.Windows.Forms.Button
    Friend WithEvents lblLore As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
