Public Class GridLineDataGridView
    Inherits DataGridView


    'Old OnPaint Event

    'Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
    '    MyBase.OnPaint(e)
    '    Dim rowHeight As Integer = Me.RowTemplate.Height
    '    Dim h As Integer = Me.ColumnHeadersHeight + rowHeight * Me.RowCount
    '    Dim imgWidth As Integer = Me.Width - 2
    '    Dim rFrame As Rectangle = New Rectangle(0, 0, imgWidth, rowHeight)
    '    Dim rFill As Rectangle = New Rectangle(1, 1, imgWidth - 2, rowHeight)
    '    Dim rowHeader As Rectangle = New Rectangle(2, 2, Me.RowHeadersWidth - 3, rowHeight)
    '    Dim pen As Pen = New Pen(Me.GridColor, 1)
    '    Dim rowImg As Bitmap = New Bitmap(imgWidth, rowHeight)
    '    Dim g As Graphics = Graphics.FromImage(rowImg)
    '    g.DrawRectangle(pen, rFrame)
    '    g.FillRectangle(New SolidBrush(Me.DefaultCellStyle.BackColor), rFill)
    '    g.FillRectangle(New SolidBrush(Me.RowHeadersDefaultCellStyle.BackColor), rowHeader)
    '    Dim rowImgAAlternative As Bitmap = TryCast(rowImg.Clone(), Bitmap)
    '    Dim g2 As Graphics = Graphics.FromImage(rowImgAAlternative)
    '    rFill.X += Me.RowHeadersWidth - 1
    '    g2.FillRectangle(New SolidBrush(Me.AlternatingRowsDefaultCellStyle.BackColor), rFill)
    '    Dim w As Integer = Me.RowHeadersWidth - 1

    '    For j As Integer = 0 To Me.ColumnCount - 1
    '        g.DrawLine(pen, New Point(w, 0), New Point(w, rowHeight))
    '        g2.DrawLine(pen, New Point(w, 0), New Point(w, rowHeight))
    '        w += Me.Columns(j).Width
    '    Next

    '    Dim [loop] As Integer = (Me.Height - h) / rowHeight

    '    'For j As Integer = 0 To [loop] + 1 - 1
    '    For j As Integer = 0 To [loop] + 1 - 1
    '        Dim index As Integer = Me.RowCount + j

    '        If index Mod 2 = 0 Then
    '            e.Graphics.DrawImage(rowImg, 1, h + j * rowHeight)
    '        Else
    '            e.Graphics.DrawImage(rowImgAAlternative, 1, h + j * rowHeight)
    '        End If
    '    Next
    'End Sub


    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim rHeaderWidth As Integer
        If Me.RowHeadersVisible = True Then
            rHeaderWidth = Me.RowHeadersWidth
        Else
            rHeaderWidth = 0
        End If

        Dim cHeadersHeight As Integer
        If Me.ColumnHeadersVisible = True Then
            cHeadersHeight = Me.ColumnHeadersHeight
        Else
            cHeadersHeight = 0
        End If

        Dim rowHeight As Integer = Me.RowTemplate.Height
        Dim h As Integer = 0 + rowHeight * Me.RowCount
        Dim imgWidth As Integer = Me.Width - 2
        Dim rFrame As Rectangle = New Rectangle(0, 0, imgWidth, rowHeight)
        Dim rFill As Rectangle = New Rectangle(1, 1, imgWidth - 2, rowHeight)
        Dim rowHeader As Rectangle = New Rectangle(2, 2, rHeaderWidth - 3, rowHeight)
        Dim pen As Pen = New Pen(Me.GridColor, 1)
        Dim rowImg As Bitmap = New Bitmap(imgWidth, rowHeight)
        Dim g As Graphics = Graphics.FromImage(rowImg)
        g.DrawRectangle(pen, rFrame)
        g.FillRectangle(New SolidBrush(Me.DefaultCellStyle.BackColor), rFill)
        'g.FillRectangle(New SolidBrush(Me.RowHeadersDefaultCellStyle.BackColor), rowHeader)
        g.FillRectangle(New SolidBrush(Me.DefaultCellStyle.BackColor), rowHeader)
        Dim rowImgAAlternative As Bitmap = TryCast(rowImg.Clone(), Bitmap)
        Dim g2 As Graphics = Graphics.FromImage(rowImgAAlternative)
        rFill.X += rHeaderWidth - 1
        g2.FillRectangle(New SolidBrush(Me.AlternatingRowsDefaultCellStyle.BackColor), rFill)

        Dim w As Integer = rHeaderWidth - 1

        For j As Integer = 0 To Me.ColumnCount - 1
            g.DrawLine(pen, New Point(w, 0), New Point(w, rowHeight))
            g2.DrawLine(pen, New Point(w, 0), New Point(w, rowHeight))
            w += Me.Columns(j).Width
        Next

        Dim [loop] As Integer = (Me.Height - h) / rowHeight


        For j As Integer = 0 To [loop] + 1 - 1
            Dim index As Integer = Me.RowCount + j

            If index Mod 2 = 0 Then
                e.Graphics.DrawImage(rowImg, 1, h + j * rowHeight)
            Else
                e.Graphics.DrawImage(rowImgAAlternative, 1, h + j * rowHeight)
            End If
        Next
    End Sub
End Class
