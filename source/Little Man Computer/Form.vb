Imports System.Text.RegularExpressions

Public Class Form
    ' This allows us to wait for input and not have the program run to quickly for us too see it
    Public Declare Sub Sleep Lib "kernel32" Alias "Sleep" (ByVal dwMilliseconds As Long)

    Dim bolWaitingForInput As Boolean = False
    Dim bolStopProgram As Boolean = False
    Dim intDelayEachRound As Integer = 2
    Dim bolStepping As Boolean = False
    Dim bolWelcomeViewed As Boolean = False

    Private Function inArray(ByVal needle As String, ByVal haystack As Array)
        'Checks if the needle is in the haystack
        For Each straw As String In haystack
            If straw = needle Then
                'Needle found YAY :D
                Return True
                Exit Function
            End If
        Next
        Return False
    End Function

    Private Sub addMSG(ByVal message As String, Optional ByVal newline As Boolean = True)
        If Not bolWelcomeViewed Then 'We dont want the welcome message to still show
            bolWelcomeViewed = True
            txtMesssage.Text = ""
        End If
        'Adds a new line of text to the message box
        txtMesssage.Text = txtMesssage.Text + message
        'If we actually want to add a new line (default is yes)
        If newline Then
            txtMesssage.Text = txtMesssage.Text + vbCrLf
        End If
    End Sub

    Private Sub btnClearMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearMessage.Click
        'Clear all of the messages
        txtMesssage.Text = ""
    End Sub

    Private Sub btnCompile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompile.Click
        bolStopProgram = True
        If Not txtMesssage.Text = "" Then 'We need something to compile so we only do somethign if the textbox has contents
            If txtMesssage.Lines.Count > 100 Then 'If theres over 100 lines it will  have to cut some stuff off so we offer the user a choice
                If MsgBox("There are too many commands to fully compile, do you want to continue?", MsgBoxStyle.YesNo, "Too many Commands") = MsgBoxResult.No Then
                    addMSG("COMPILE HALTED" + vbCrLf)
                    Exit Sub
                End If
            End If
            Dim strNonCompiled() As String = txtMesssage.Lines 'Import the text we are going to compile into an array
            Dim strCompiledCommand As String = ""
            Dim strCommandList() As String = {"ADD", "SUB", "STA", "LDA", "BRA", "BRZ", "BRP", "INP", "OUT", "HLT"} 'String containing all of the commands which are used so theyd ont get mixed up with variable names
            Dim strVariables() As String = {} 'This array will contain all of the variables and line numbers we need
            txtMesssage.Text = "-- COMPILING PROJECT --" + vbCrLf + vbCrLf 'Reset the message box
            ' Reset all of richtextboxes
            rtbCommands1.Text = ""
            rtbCommands2.Text = ""
            rtbCommands3.Text = ""
            For Each strLine In strNonCompiled
                'Check if its alphabetic, contains a space and checks if there is a variable name
                If Not inArray(strLine.Split(" ")(0).ToUpper, strCommandList) And Regex.IsMatch(strLine.Split(" ")(0), "^[a-zA-Z]*$") And strLine.Contains(" ") Then
                    'Possible variable name
                    If Not inArray(strLine.Split(" ")(0).ToUpper, strVariables) And strLine.Split(" ")(0).ToUpper.Length > 0 Then
                        'If not in the array of existing variable names
                        ReDim Preserve strVariables(0 To strVariables.Count) 'Increase the size of the array
                        strVariables(strVariables.Count - 1) = CStr(Array.IndexOf(strNonCompiled, strLine)).PadLeft(2, "0") + strLine.Split(" ")(0).ToUpper
                        addMSG("Varible " + strLine.Split(" ")(0).ToUpper + " defined as " + CStr(Array.IndexOf(strNonCompiled, strLine)).PadLeft(2, "0")) 'Add text to teh message box
                    End If
                End If
            Next
            addMSG("") 'Add a blank line
            For Each strLine In strNonCompiled
                If strLine.Trim(" ", vbTab).Length >= 3 Then
                    ' Remove any location names as we no longer need them.
                    If Not inArray(strLine.Trim(" ", vbTab).Split(" ")(0).ToUpper, strCommandList) And strLine.Trim(" ", vbTab).Contains(" ") And Not strLine.Trim(" ", vbTab) = " " Then
                        strLine = strLine.Trim(" ", vbTab).Substring(strLine.Split(" ")(0).Length + 1, strLine.Length - strLine.Trim(" ", vbTab).Split(" ")(0).Length - 1)
                    End If
                    If strLine.Trim(" ", vbTab).Split(" ").Count > 1 Then
                        If Regex.IsMatch(strLine.Trim(" ", vbTab).Split(" ")(1), "^[a-zA-Z]*$") Then 'If alphabetic
                            For Each strVariable In strVariables
                                strLine = Replace(strLine.Trim(" ", vbTab).ToUpper, " " + strVariable.Substring(2, strVariable.Length - 2).ToUpper, " " + strVariable.Substring(0, 2))
                            Next
                        End If
                    End If
                    strLine = strLine.Trim(" ", vbTab).PadRight(6, "0") 'Pad the string to correct length that we need
                    Select Case strLine.Substring(0, 3).ToUpper
                        Case "ADD" 'Addition
                            strCompiledCommand = "1" + strLine.Trim(" ", vbTab).Substring(4, 2) + vbCrLf
                        Case "SUB" 'Subtraction
                            strCompiledCommand = "2" + strLine.Trim(" ", vbTab).Substring(4, 2) + vbCrLf
                        Case "STA" 'Store
                            strCompiledCommand = "3" + strLine.Trim(" ", vbTab).Substring(4, 2) + vbCrLf
                        Case "LDA" 'Load
                            strCompiledCommand = "5" + strLine.Trim(" ", vbTab).Substring(4, 2) + vbCrLf
                        Case "BRA" 'Branch always
                            strCompiledCommand = "6" + strLine.Trim(" ", vbTab).Substring(4, 2) + vbCrLf
                        Case "BRZ" 'Branch if zero
                            strCompiledCommand = "7" + strLine.Trim(" ", vbTab).Substring(4, 2) + vbCrLf
                        Case "BRP" 'Branh if zero or positive
                            strCompiledCommand = "8" + strLine.Trim(" ", vbTab).Substring(4, 2) + vbCrLf
                        Case "INP" 'Ask the user for input
                            strCompiledCommand = "901" + vbCrLf
                        Case "OUT" 'Output
                            strCompiledCommand = "902" + vbCrLf
                        Case "HLT" 'Stop running the program (kinda optional)
                            strCompiledCommand = "000" + vbCrLf
                        Case "DAT" 'Data
                            'We need to increase the size of the string by one
                            strLine = strLine.Trim(" ", vbTab).PadRight(7, "0")
                            strCompiledCommand = strLine.Trim(" ", vbTab).Substring(4, 3) + vbCrLf
                        Case Else 'Uh, oh, an invalid command has been entered and its not a variable name
                            If Not strLine.Trim(" ", vbTab) = "" Then 'If not blank as we can simpyl ignore blanks
                                addMSG(strLine.Trim(" ", vbTab).Substring(0, 3).ToUpper + " - Invalid Command!")
                                Exit Sub 'Stop compiling
                            End If
                    End Select
                    'Say what each line has been converted into
                    addMSG(strLine.Substring(0, 3).ToUpper + " - " + strCompiledCommand, False)
                    'This next part means that the compiled code will be split into the three different boxes
                    If rtbCommands1.Lines.Count <= 34 Then
                        rtbCommands1.Text = rtbCommands1.Text + strCompiledCommand
                    ElseIf rtbCommands2.Lines.Count <= 34 Then
                        rtbCommands2.Text = rtbCommands2.Text + strCompiledCommand
                    Else
                        rtbCommands3.Text = rtbCommands3.Text + strCompiledCommand
                    End If
                End If
            Next
            'Compile completed
            addMSG(vbCrLf + "COMPILE SUCESS")
        Else
            addMSG("Please type something before trying to compile, if you need help click 'Load a Project'")
        End If
    End Sub

    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        Reset() 'Resets the bottom bar among other things so we can start afresh
        btnRun.Enabled = False
        Dim strCommands(0 To 0) As String 'An array which will conatin all of the commands once they have been loaded from the richtextboxes
        Dim elements() As System.Windows.Forms.RichTextBox = {rtbCommands1, rtbCommands2, rtbCommands3} 'List of richtextboxes
        Dim rtbSelected As System.Windows.Forms.RichTextBox = rtbCommands1 'A variable which stores the current richtextbox
        Dim intSelectedMaxLineCount As Integer = 34 'The max line count of the currently selected textbox
        Dim intSelectedPadding As Integer = 0 'The total max lines of all the richtextboxes before us
        For Each element In elements
            'This select statement just works out which richtextbox we are using
            Select Case element.Name
                Case rtbCommands1.Name
                    intSelectedMaxLineCount = 34
                    intSelectedPadding = 0
                Case rtbCommands2.Name
                    intSelectedMaxLineCount = 34
                    intSelectedPadding = 34
                Case rtbCommands3.Name
                    intSelectedMaxLineCount = 32
                    intSelectedPadding = 68
            End Select
            element.ReadOnly = True 'Disable the current richtextbox so the user cant fidle
            'These few lines select all of the lines and turn them regualr and black so its reset from last time
            element.SelectionStart = 0
            element.SelectionLength = element.Text.Length
            element.SelectionColor = Color.Black
            element.SelectionFont = New Font(element.Font, FontStyle.Regular)
            'This for loop simply either adds all of the lines in all the richtextboxes to an array so it is easier to work with
            For intCount As Integer = 0 To intSelectedMaxLineCount - 1
                ReDim Preserve strCommands(0 To (intCount + intSelectedPadding)) 'Increase the size of the array by one
                If intCount <= element.Lines.Count - 1 Then 'We need to ensure that the rich text box has enough lines so we dont get nasty fatal errors
                    If Not IsNumeric(element.Lines(intCount)) And Not element.Lines(intCount) = "" Then 'If not numeric and isnt blank
                        addMSG("Possible error, non blank, non numeric line in " + element.Name + " on line " + CStr(intCount)) 'Tell the users
                        strCommands(intCount + intSelectedPadding) = "000" 'Set it as 000 in the array
                    Else
                        'Its fine :D
                        If element.Lines(intCount).Length < 3 And Not element.Lines(intCount).Length = 0 Then
                            Dim intTemp As Integer = 0 'Variable to store the comibned length of every line before the current one
                            For intC As Integer = 0 To intCount - 1
                                intTemp = intTemp + element.Lines(intC).Length + 1 'Add the length to the count and the 1 for the linebreak
                            Next
                            element.SelectionStart = intTemp
                            element.SelectionLength = element.Lines(intCount).Length
                            element.SelectedText = element.Lines(intCount).PadLeft(3, "0")
                            strCommands(intCount + intSelectedPadding) = element.Lines(intCount) 'Add to the array
                        ElseIf element.Lines(intCount).Length >= 3 Then
                            Dim intTemp As Integer = 0 'Variable to store the comibned length of every line before the current one
                            For intC As Integer = 0 To intCount - 1
                                intTemp = intTemp + element.Lines(intC).Length + 1 'Add the length to the count and the 1 for the linebreak
                            Next
                            element.SelectionStart = intTemp
                            element.SelectionLength = element.Lines(intCount).Length
                            element.SelectedText = element.Lines(intCount).Substring(0, 3)
                            strCommands(intCount + intSelectedPadding) = element.Lines(intCount) 'Add to the array
                        Else
                            'Not every line was full
                            strCommands(intCount + intSelectedPadding) = "000"
                        End If
                    End If
                Else
                    'Not every line was full
                    strCommands(intCount + intSelectedPadding) = "000"
                End If
            Next
        Next
        'The program is technically about to execute now
        addMSG(vbCrLf + "-- PROGRAM STARTING --" + vbCrLf)
        For intCount As Integer = 0 To strCommands.Count - 1
            If bolStopProgram = True Then
                bolStopProgram = False
                addMSG("Program Halted" + vbCrLf)
                For Each element In elements
                    element.ReadOnly = False
                Next
                btnRun.Enabled = True
                btnStep.Enabled = True
                Exit Sub
            End If
            For Each element In elements
                'Select all of the text
                element.SelectionStart = 0
                element.SelectionLength = element.TextLength
                'Make it all regular and not bold
                element.SelectionFont = New Font(element.Font, FontStyle.Regular)
            Next
            'Work out which rich textbox is selected
            If intCount <= 33 Then
                rtbSelected = rtbCommands1
                intSelectedMaxLineCount = 34
            ElseIf intCount >= 68 Then
                rtbSelected = rtbCommands3
                intSelectedMaxLineCount = 32
            Else
                rtbSelected = rtbCommands2
                intSelectedMaxLineCount = 34
            End If
            Dim intTemp As Integer = 0 'Variable to store the comibned length of every line before the current one
            For intC As Integer = 0 To intCount - 1
                intTemp = intTemp + rtbSelected.Lines(intC).Length + 1 'Add the length to the count and the 1 for the linebreak
            Next
            rtbSelected.SelectionStart = intTemp 'Select the line which is being executed in the richtextbox
            rtbSelected.SelectionLength = strCommands(intCount).Length
            rtbSelected.SelectionFont = New Font(rtbSelected.Font, FontStyle.Bold) 'Make the line bold
            rtbSelected.SelectionColor = Color.Blue 'And blue
            txtMEMAddress.Text = CStr(intCount).PadLeft(2, "0") 'The selected memory address for those to lazy to look to the left
            txtMEMData.Text = CStr(strCommands(intCount)).PadLeft(3, "0") 'The contents of the currently executing line
            txtCounter.Text = txtCounter.Text + 1 'This is how many lines of code we have run and we increase it by one
            addMSG(strCommands(intCount).PadLeft(3, "0") + " - ", False)
            If strCommands(intCount).Length >= 3 Then
                Select Case strCommands(intCount).Substring(0, 1)
                    Case 1 'Add
                        txtAccumulator.Text = CInt(txtAccumulator.Text) + CInt(strCommands(strCommands(intCount).Substring(1, 2)))
                        addMSG("Adding contents of address: " + strCommands(intCount).Substring(1, 2) + " to the accumulator, new value: " + txtAccumulator.Text)
                    Case 2 'Subtract
                        txtAccumulator.Text = CInt(txtAccumulator.Text) - CInt(strCommands(strCommands(intCount).Substring(1, 2)))
                        addMSG("Subtracting contents of address: " + strCommands(intCount).Substring(1, 2) + " to the accumulator, new value: " + txtAccumulator.Text)
                    Case 3 'Store
                        addMSG("Storing the value of the Accumulator in address: " + strCommands(intCount).Substring(1, 2))
                        'Work out which richtextbox the value we need to updae lies in
                        If strCommands(intCount).Substring(1, 2) <= 33 Then
                            rtbSelected = rtbCommands1
                            intSelectedPadding = 0
                        ElseIf strCommands(intCount).Substring(1, 2) >= 68 Then
                            rtbSelected = rtbCommands3
                            intSelectedPadding = 68
                        Else
                            rtbSelected = rtbCommands2
                            intSelectedPadding = 34
                        End If
                        'This pads out the selected richtextbox with linebreaks until it reahes the line it needs to
                        While rtbSelected.Lines.Count < strCommands(intCount).Substring(1, 2) - (intSelectedPadding - 1)
                            rtbSelected.Text = rtbSelected.Text + vbCrLf 'Add a linebreak
                        End While
                        intTemp = 0
                        For intC As Integer = intSelectedPadding To strCommands(intCount).Substring(1, 2) - 1 'Gets the length of all the liens befoer the current one so we can select it and update it
                            intTemp = intTemp + rtbSelected.Lines(intC - intSelectedPadding).Length + 1
                        Next
                        rtbSelected.SelectionStart = intTemp
                        rtbSelected.SelectionLength = rtbSelected.Lines(strCommands(intCount).Substring(1, 2) - intSelectedPadding).Length 'This line firslt works out what line we are goign to store in, then it works out the length of that line so we can replace the contents with the new contents
                        rtbSelected.SelectionColor = Color.Purple
                        rtbSelected.SelectedText = txtAccumulator.Text.PadLeft(3, "0") 'Update the text with a 3digit number
                        strCommands(strCommands(intCount).Substring(1, 2)) = txtAccumulator.Text.PadLeft(3, "0") 'Update th value in the array (VERY IMPORTANT!!!)
                    Case 4 'Non command
                        addMSG("Sigh, 4xx isnt a command in the little man computer :(" + vbCrLf)
                        rtbSelected.SelectionColor = Color.Red 'We want the current line to be RED so we know where we stopped executing the program
                        For Each element In elements
                            element.ReadOnly = False 'Make every rich textbox editable as the program is no longer running
                        Next
                        btnStep.Enabled = True
                        btnRun.Enabled = True
                        Exit For 'Stop executing
                    Case 5 'Load
                        addMSG("Loading the value of address: " + strCommands(intCount).Substring(1, 2) + " into the accumulator")
                        txtAccumulator.Text = CInt(strCommands(strCommands(intCount).Substring(1, 2))) 'Load the value 
                    Case 6 'Branch always
                        If Not intCount = strCommands(intCount).Substring(1, 2) - 1 Then
                            addMSG("Branching to line " + strCommands(intCount).Substring(1, 2))
                            intCount = strCommands(intCount).Substring(1, 2) - 1 'Just change the value of intCount to change line, its simple
                        End If
                    Case 7 'Branch if 0
                        'If the line number isnt the current one (To stop some idiotic infinite loops) and it is zero
                        If Not intCount = strCommands(intCount).Substring(1, 2) - 1 And CInt(txtAccumulator.Text) = 0 Then
                            addMSG("Branching to line " + strCommands(intCount).Substring(1, 2))
                            intCount = strCommands(intCount).Substring(1, 2) - 1 'Change intCount
                        Else
                            addMSG("The value in the accumulator isnt 0!")
                        End If
                    Case 8 'Branch is zero or positive
                        If Not intCount = strCommands(intCount).Substring(1, 2) - 1 And CInt(txtAccumulator.Text) >= 0 Then
                            addMSG("Branching to line " + strCommands(intCount).Substring(1, 2))
                            intCount = strCommands(intCount).Substring(1, 2) - 1
                        Else
                            addMSG("The value in the accumulator isnt 0 or positive!")
                        End If
                    Case 9 'Input and Output
                        If strCommands(intCount).Substring(2, 1) = 1 Then 'Input
                            rtbSelected.SelectionColor = Color.Green 'Change to green
                            addMSG("Asking user for input")
                            txtInbox.ReadOnly = False 'Make the Inbox editable
                            btnInboxSubmit.Enabled = True
                            Beep() 'Beep the user to get their attention if we can
                            bolWaitingForInput = True
                            btnStep.Enabled = False
                            While bolWaitingForInput = True 'Wait for there input
                                Sleep(50)
                                System.Windows.Forms.Application.DoEvents() 'Allows the form to not freeze
                                If bolStopProgram Then 'Otherwise the old program doesnt always clear if you compile an new one at this point
                                    Exit Sub
                                End If
                            End While
                            btnStep.Enabled = True
                            txtAccumulator.Text = txtInbox.Text 'Update the value in the accumulator
                            txtInbox.ReadOnly = True 'Make the inbox readonly as we dont need users to mess with it
                            btnInboxSubmit.Enabled = False 'Disable the button
                        ElseIf strCommands(intCount).Substring(2, 1) = 2 Then 'Output
                            rtbSelected.SelectionColor = Color.Green 'Change to green
                            If txtAccumulator.Text.Contains("-") Then
                                txtOutbox.Text = "-" + txtAccumulator.Text.Substring(1, txtAccumulator.TextLength - 2).PadLeft(3, "0")
                                addMSG("Outputting: " + "-" + txtAccumulator.Text.Substring(1, txtAccumulator.TextLength - 2).PadLeft(3, "0") + vbCrLf)
                            Else
                                txtOutbox.Text = txtAccumulator.Text.PadLeft(3, "0")
                                addMSG("Outputting: " + txtAccumulator.Text.PadLeft(3, "0") + vbCrLf)
                            End If
                        Else
                            'Doesnt really need to be fatal but the USER FAILS BADLY SO WE FORCE THEM TO ACTUALLY FIX THIS!!!
                            addMSG("Invalid Command: " + strCommands(intCount) + ", did you mean INP(901) or OUT(902)?" + vbCrLf)
                            For Each element In elements
                                element.ReadOnly = False 'Allow the user to edit the richtextboxes
                            Next
                            btnRun.Enabled = True
                            btnStep.Enabled = True
                            Exit For
                        End If
                    Case 0 'End
                        rtbSelected.SelectionColor = Color.Red 'Change the line color to red to indicate we have stopped
                        addMSG("Program Halted" + vbCrLf)
                        For Each element In elements
                            element.ReadOnly = False
                        Next
                        btnRun.Enabled = True
                        btnStep.Enabled = True
                        Exit For
                    Case Else 'Idiot fallback
                        rtbSelected.SelectionColor = Color.Red
                        addMSG("ERROR, INVALID COMMAND!" + vbCrLf)
                        For Each element In elements
                            element.ReadOnly = False
                        Next
                        btnRun.Enabled = True
                        btnStep.Enabled = True
                        Exit For
                End Select
            End If
            'Auto scroll after each command just before the 50*x wait
            txtMesssage.SelectionStart = txtMesssage.TextLength
            txtMesssage.ScrollToCaret()
            If intCount = strCommands.Count Then 'If on the last line we stop running the program
                For Each element In elements
                    element.ReadOnly = False
                Next
                addMSG("Program Halted" + vbCrLf)
                btnRun.Enabled = True
                btnStep.Enabled = True
                Exit For
            End If
            If bolStepping = True Then 'If we want to step (ITS FUN :D)
                bolWaitingForInput = True
                addMSG("Waiting for step")
                'Wait for the user to ........ PRESS THE BUTTON
                While bolWaitingForInput = True
                    Sleep(50 * intDelayEachRound)
                    System.Windows.Forms.Application.DoEvents() 'Magic
                End While
            Else
                For intC As Integer = 0 To intDelayEachRound
                    Sleep(50 * intDelayEachRound)
                    'Allows the user to interact while the form is sleeping
                    System.Windows.Forms.Application.DoEvents()
                Next
            End If
        Next
        For Each element In elements 'Loops through the three different richtextboxes
            'Make them no read only
            element.ReadOnly = False
        Next
        btnRun.Enabled = True
        btnStep.Enabled = True
        'Neat bit of code which means that the textbox autoscrolls which is handy
        txtMesssage.SelectionStart = txtMesssage.TextLength
        txtMesssage.ScrollToCaret()
    End Sub

    Private Sub btnInboxSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInboxSubmit.Click
        If Not txtInbox.Text = "" And IsNumeric(txtInbox.Text) Then 'We want input boxes with numbers only, blanks arent allowed
            bolWaitingForInput = False 'Alert the running program that we have entered something that is valid
            addMSG("Text inputed: " + txtInbox.Text + vbCrLf)
        Else
            addMSG("Invalid entry")
        End If
    End Sub

    Private Sub Halt() Handles btnHalt.Click
        bolStopProgram = True 'Varibale checked every iteration
        addMSG("Program Halted" + vbCrLf)
    End Sub

    Private Sub ClearAll() Handles btnClearAll.Click
        'Simply clears every single thing
        rtbCommands1.Text = ""
        rtbCommands2.Text = ""
        rtbCommands3.Text = ""
        txtMesssage.Text = ""
        Reset()
        bolStopProgram = True
        addMSG("Program Cleared" + vbCrLf)
    End Sub

    Private Sub Reset() Handles btnReset.Click
        intDelayEachRound = 2 'Resest the dealy to 100ms
        bolStopProgram = False 'Means that it wont stop imediantly
        bolWaitingForInput = False
        bolStepping = False 'Doesnt step again
        btnRun.Enabled = True
        btnStep.Enabled = True
        'Reset the bottom bar
        txtAccumulator.Text = "0"
        txtCounter.Text = "0"
        txtMEMAddress.Text = "00"
        txtMEMData.Text = "000"
        txtInbox.Text = ""
        txtInbox.ReadOnly = True
        btnInboxSubmit.Enabled = False
        txtOutbox.Text = ""
    End Sub

    Private Sub Slow() Handles btnSlow.Click
        intDelayEachRound = 4 'This variable stores how long you want to wait after compiling a line which is then multiplied by 50
        addMSG("Program Slowed" + vbCrLf)
    End Sub

    Private Sub StepInstruction() Handles btnStep.Click
        bolStepping = True 'This variable is checked by btnRun every iteration to check if we want to step
        bolWaitingForInput = False 'This allows us to go to the next step
        addMSG("Program now steps" + vbCrLf)
    End Sub

    Private Sub LoadProjectPopUp() Handles llbLoadProject.LinkClicked
        'Simply bring up the Projects popup, simples
        Projects.Show()
    End Sub

    Private Sub txtMesssage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMesssage.Click
        'Check if it has been cleared before and if it has the defeult content
        If txtMesssage.TextLength > 6 Then
            If Not bolWelcomeViewed And txtMesssage.Text.Substring(0, 6) = "Little" Then
                bolWelcomeViewed = True
                txtMesssage.Text = ""
            End If
        End If
    End Sub

End Class
