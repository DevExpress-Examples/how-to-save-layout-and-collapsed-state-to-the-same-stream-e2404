Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication53
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.dataSet1 = New System.Data.DataSet()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.dataColumn2 = New System.Data.DataColumn()
			Me.dataColumn3 = New System.Data.DataColumn()
			Me.fiedName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldDate = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldValue = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton3 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.DataMember = "Data"
			Me.pivotGridControl1.DataSource = Me.dataSet1
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fiedName, Me.fieldDate, Me.fieldValue, Me.fieldDate1})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(796, 292)
			Me.pivotGridControl1.TabIndex = 0
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2, Me.dataColumn3})
			Me.dataTable1.TableName = "Data"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "Name"
			' 
			' dataColumn2
			' 
			Me.dataColumn2.ColumnName = "Date"
			Me.dataColumn2.DataType = GetType(System.DateTime)
			' 
			' dataColumn3
			' 
			Me.dataColumn3.ColumnName = "Value"
			Me.dataColumn3.DataType = GetType(Decimal)
			' 
			' fiedName
			' 
			Me.fiedName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fiedName.AreaIndex = 0
			Me.fiedName.FieldName = "Name"
			Me.fiedName.Name = "fiedName"
			' 
			' fieldDate
			' 
			Me.fieldDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldDate.AreaIndex = 0
			Me.fieldDate.Caption = "Year"
			Me.fieldDate.FieldName = "Date"
			Me.fieldDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldDate.Name = "fieldDate"
			Me.fieldDate.UnboundFieldName = "fieldDate"
			' 
			' fieldValue
			' 
			Me.fieldValue.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldValue.AreaIndex = 0
			Me.fieldValue.Caption = "Sum"
			Me.fieldValue.FieldName = "Value"
			Me.fieldValue.Name = "fieldValue"
			' 
			' fieldDate1
			' 
			Me.fieldDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldDate1.AreaIndex = 1
			Me.fieldDate1.Caption = "Date"
			Me.fieldDate1.FieldName = "Date"
			Me.fieldDate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date
			Me.fieldDate1.Name = "fieldDate1"
			Me.fieldDate1.UnboundFieldName = "fieldDate1"
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(275, 0)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(135, 23)
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "Save"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Location = New System.Drawing.Point(557, 0)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(135, 23)
			Me.simpleButton2.TabIndex = 2
			Me.simpleButton2.Text = "Restore"
'			Me.simpleButton2.Click += New System.EventHandler(Me.simpleButton2_Click);
			' 
			' simpleButton3
			' 
			Me.simpleButton3.Location = New System.Drawing.Point(416, 0)
			Me.simpleButton3.Name = "simpleButton3"
			Me.simpleButton3.Size = New System.Drawing.Size(135, 23)
			Me.simpleButton3.TabIndex = 3
			Me.simpleButton3.Text = "Clear"
'			Me.simpleButton3.Click += New System.EventHandler(Me.simpleButton3_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(796, 292)
			Me.Controls.Add(Me.simpleButton3)
			Me.Controls.Add(Me.simpleButton2)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private dataColumn2 As System.Data.DataColumn
		Private dataColumn3 As System.Data.DataColumn
		Private fiedName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldDate As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldValue As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldDate1 As DevExpress.XtraPivotGrid.PivotGridField
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton3 As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

