Imports System.IO

Module DataBaseHandler

    Public Sub csvTodtTable(ByRef dt As DataTable, filename As String, Optional delim As Char = ","c)
        On Error GoTo ErrHandler

        Dim lines = File.ReadAllLines(filename)
        Dim colCount = lines.First.Split(delim).Length

        For Each c As String In lines.First.Split(delim)
            dt.Columns.Add(New DataColumn(c))
        Next

        For Each line In String.Join(vbLf, lines, 1, lines.Length - 1).Split(vbLf)
            Dim objFields = From field In line.Split(delim) Select CType(field, Object)
            Dim newRow = dt.Rows.Add()
            newRow.ItemArray = objFields.ToArray()
        Next

ErrHandler:
        If Not Err.Number = 0 Then
            Dim usr As MsgBoxResult = MsgBox("(" & Err.Number & ") " & Err.Description, vbCritical + vbAbortRetryIgnore)
            If usr = MsgBoxResult.Abort Then
                Exit Sub
            ElseIf usr = MsgBoxResult.Retry Then
                Resume
            Else
                Resume Next
            End If
        End If

    End Sub

    Public Sub dtTableToCSV(dt As DataTable, filename As String, Optional headers As Boolean = True, Optional delim As Char = ","c)
        On Error GoTo ErrHandler
        Dim txt As String = vbNullString

        If File.Exists(filename) Then File.Delete(filename)

        Dim n = 0
        If headers = True Then
            For Each column As DataColumn In dt.Columns
                If n = 0 Then
                    txt += column.ColumnName
                Else
                    txt += delim + column.ColumnName
                End If
                n += 1
            Next
        End If

        txt += vbCrLf
        n = 0
        For Each row As DataRow In dt.Rows
            Dim line As String = ""

            For Each column As DataColumn In dt.Columns
                line += delim & row(column.ColumnName).ToString()
            Next
            If dt.Rows.Count - 1 = n Then
                txt += line.Substring(1)
            Else
                txt += line.Substring(1) & vbCrLf
            End If
            n += 1
        Next

        Using sw As StreamWriter = New StreamWriter(filename)
            sw.Write(txt)
        End Using

        dt.Dispose()

ErrHandler:
        If Not Err.Number = 0 Then
            Dim usr As MsgBoxResult = MsgBox("(" & Err.Number & ") " & Err.Description, vbCritical + vbAbortRetryIgnore)
            If usr = MsgBoxResult.Abort Then
                Exit Sub
            ElseIf usr = MsgBoxResult.Retry Then
                Resume
            Else
                Resume Next
            End If
        End If

    End Sub

End Module
