<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PtxMinimizar = New System.Windows.Forms.PictureBox()
        Me.PtxNormal = New System.Windows.Forms.PictureBox()
        Me.PtxCerrar = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PtxMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtxNormal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtxCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(800, 38)
        Me.Panel1.TabIndex = 3
        '
        'PtxMinimizar
        '
        Me.PtxMinimizar.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.PtxMinimizar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PtxMinimizar.Image = CType(resources.GetObject("PtxMinimizar.Image"), System.Drawing.Image)
        Me.PtxMinimizar.Location = New System.Drawing.Point(660, 3)
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
        Me.PtxNormal.Location = New System.Drawing.Point(706, 3)
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
        Me.PtxCerrar.Location = New System.Drawing.Point(754, 3)
        Me.PtxCerrar.Name = "PtxCerrar"
        Me.PtxCerrar.Size = New System.Drawing.Size(34, 32)
        Me.PtxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PtxCerrar.TabIndex = 0
        Me.PtxCerrar.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(703, 404)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 41)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(163, 103)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 183)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PtxMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtxNormal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtxCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PtxMinimizar As PictureBox
    Friend WithEvents PtxNormal As PictureBox
    Friend WithEvents PtxCerrar As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
