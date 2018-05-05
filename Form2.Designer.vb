<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtawal = New System.Windows.Forms.TextBox()
        Me.txtakhir = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnproses = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(406, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "URUTAN NILAI AWAL SAMPAI AKHIR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nilai Awal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nilai Akhir"
        '
        'txtawal
        '
        Me.txtawal.Location = New System.Drawing.Point(159, 102)
        Me.txtawal.Name = "txtawal"
        Me.txtawal.Size = New System.Drawing.Size(136, 20)
        Me.txtawal.TabIndex = 3
        '
        'txtakhir
        '
        Me.txtakhir.Location = New System.Drawing.Point(159, 142)
        Me.txtakhir.Name = "txtakhir"
        Me.txtakhir.Size = New System.Drawing.Size(136, 20)
        Me.txtakhir.TabIndex = 4
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(310, 102)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(161, 212)
        Me.ListBox1.TabIndex = 5
        '
        'btnproses
        '
        Me.btnproses.Location = New System.Drawing.Point(69, 182)
        Me.btnproses.Name = "btnproses"
        Me.btnproses.Size = New System.Drawing.Size(105, 55)
        Me.btnproses.TabIndex = 6
        Me.btnproses.Text = "Proses"
        Me.btnproses.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(190, 182)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(105, 55)
        Me.btnhapus.TabIndex = 7
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Location = New System.Drawing.Point(69, 259)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(226, 55)
        Me.btnnext.TabIndex = 8
        Me.btnnext.Text = "Next"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 378)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnproses)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.txtakhir)
        Me.Controls.Add(Me.txtawal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtawal As System.Windows.Forms.TextBox
    Friend WithEvents txtakhir As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnproses As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnnext As System.Windows.Forms.Button
End Class
