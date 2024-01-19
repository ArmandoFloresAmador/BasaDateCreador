<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PtxMinimizar = New System.Windows.Forms.PictureBox()
        Me.PtxNormal = New System.Windows.Forms.PictureBox()
        Me.PtxCerrar = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ocultar = New System.Windows.Forms.Timer(Me.components)
        Me.Mostrar = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimerInterval = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PtxMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtxNormal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtxCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(5, 133)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(197, 43)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(5, 188)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(197, 43)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.PtxMinimizar)
        Me.Panel1.Controls.Add(Me.PtxNormal)
        Me.Panel1.Controls.Add(Me.PtxCerrar)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(668, 38)
        Me.Panel1.TabIndex = 2
        '
        'PtxMinimizar
        '
        Me.PtxMinimizar.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.PtxMinimizar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PtxMinimizar.Image = CType(resources.GetObject("PtxMinimizar.Image"), System.Drawing.Image)
        Me.PtxMinimizar.Location = New System.Drawing.Point(528, 3)
        Me.PtxMinimizar.Name = "PtxMinimizar"
        Me.PtxMinimizar.Size = New System.Drawing.Size(34, 31)
        Me.PtxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PtxMinimizar.TabIndex = 2
        Me.PtxMinimizar.TabStop = False
        '
        'PtxNormal
        '
        Me.PtxNormal.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PtxNormal.Image = CType(resources.GetObject("PtxNormal.Image"), System.Drawing.Image)
        Me.PtxNormal.Location = New System.Drawing.Point(574, 3)
        Me.PtxNormal.Name = "PtxNormal"
        Me.PtxNormal.Size = New System.Drawing.Size(36, 31)
        Me.PtxNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PtxNormal.TabIndex = 1
        Me.PtxNormal.TabStop = False
        '
        'PtxCerrar
        '
        Me.PtxCerrar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PtxCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PtxCerrar.Image = CType(resources.GetObject("PtxCerrar.Image"), System.Drawing.Image)
        Me.PtxCerrar.Location = New System.Drawing.Point(622, 3)
        Me.PtxCerrar.Name = "PtxCerrar"
        Me.PtxCerrar.Size = New System.Drawing.Size(34, 32)
        Me.PtxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PtxCerrar.TabIndex = 0
        Me.PtxCerrar.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(5, 236)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(197, 46)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(17, 442)
        Me.Panel2.TabIndex = 3
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox4.Image = Global.AppArmando.My.Resources.Resources.Logo
        Me.PictureBox4.Location = New System.Drawing.Point(51, 47)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(116, 80)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.AppArmando.My.Resources.Resources.flechaG
        Me.PictureBox2.Location = New System.Drawing.Point(161, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(41, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'ocultar
        '
        Me.ocultar.Interval = 1
        '
        'Mostrar
        '
        Me.Mostrar.Interval = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(617, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        '
        'TimerInterval
        '
        Me.TimerInterval.Interval = 1000
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(511, 463)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Label3"
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.AppArmando.My.Resources.Resources.usuario
        Me.PictureBox1.InitialImage = Global.AppArmando.My.Resources.Resources._1f3932cbf0344f545bb121f685f6cd93
        Me.PictureBox1.Location = New System.Drawing.Point(574, 65)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.AppArmando.My.Resources.Resources.MENU
        Me.PictureBox3.Location = New System.Drawing.Point(3, 41)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(42, 45)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'Form1
        '
        Me.AcceptButton = Me.Button2
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 480)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Opacity = 0.9R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "  "
        Me.Panel1.ResumeLayout(False)
        CType(Me.PtxMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtxNormal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtxCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents PtxMinimizar As PictureBox
    Friend WithEvents PtxNormal As PictureBox
    Friend WithEvents PtxCerrar As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ocultar As Timer
    Friend WithEvents Mostrar As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents TimerInterval As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
