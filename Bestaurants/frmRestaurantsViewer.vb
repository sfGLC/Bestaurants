Imports ESRI.ArcGIS.Framework
Imports ESRI.ArcGIS.Carto
Imports ESRI.ArcGIS.ArcMapUI
Imports ESRI.ArcGIS.Geodatabase

Public Class frmRestaurantsViewer

    Private m_application As IApplication
    Public Property ArcMapApplication() As IApplication
        Get
            Return m_application
        End Get
        Set(ByVal value As IApplication)
            m_application = value
        End Set
    End Property


    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim pLayer As ILayer = getLayerByName(cmbLayers.SelectedItem.ToString)
        pLayer.Visible = True
        Dim pMxDoc As IMxDocument = m_application.Document
        pMxDoc.ActivatedView.Refresh()
        pMxDoc.UpdateContents()
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        Dim pLayer As ILayer = getLayerByName(cmbLayers.SelectedItem.ToString)
        pLayer.Visible = False
        Dim pMxDoc As IMxDocument = m_application.Document
        pMxDoc.UpdateContents()
        pMxDoc.ActivatedView.Refresh()

    End Sub
    ''' <summary>
    ''' Get the layer by name
    ''' </summary>
    ''' <param name="sLayerName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function getLayerByName(sLayerName As String) As ILayer
        Dim pMxDoc As IMxDocument = m_application.Document
        Dim pMap As IMap = pMxDoc.FocusMap
        For i As Integer = 0 To pMap.LayerCount - 1
            Dim pLayer As ILayer = pMap.Layer(i)

            If pLayer.Name = sLayerName Then
                Return pLayer
            End If
        Next
        Return Nothing
    End Function

    Private Sub btnRestaurants_Click(sender As Object, e As EventArgs) Handles btnRestaurants.Click, btnBars.Click, btnCafes.Click, btnDiners.Click, btnLounges.Click
        Dim pButton As Windows.Forms.Button = sender

        setDefinitionQuery(pButton.Tag)

        'populate the dropdown list with venues for the particular category (tag)
        'get the selected layer
        Dim pSelectedLayer As ILayer = getLayerByName(cmbLayers.SelectedItem.ToString)
        'assume this layer is a feature layer
        Dim pFeatureLayer As IFeatureLayer = pSelectedLayer
        'get the source data, the feature class
        Dim pFeatureClass As IFeatureClass = pFeatureLayer.FeatureClass

        Dim pQFilter As IQueryFilter = New QueryFilter
        pQFilter.WhereClause = "CATEGORY =" & pButton.Tag

        'get the feature cursor to iteratethrough features
        Dim pFeatureCursor As IFeatureCursor = pFeatureClass.Search(pQFilter, False)

        PopulateVenues(pFeatureCursor)

    End Sub
    ''' <summary>
    ''' Populate the venues dropdown list with the vanues from a cursor
    ''' </summary>
    ''' <param name="pFCursor"></param>
    ''' <remarks></remarks>
    Private Sub PopulateVenues(pFCursor As IFeatureCursor)
        Dim pFeature As IFeature
        pFeature = pFCursor.NextFeature

        'clear the combobox before filling values. otherwise everytime the combobox value changes duplicated values will be filled in
        cmbVenues.Items.Clear()

        Dim index As Integer = pFeature.Fields.FindField("NAME")
        Do Until pFeature Is Nothing
            Dim sName As String = pFeature.Value(index)
            cmbVenues.Items.Add(sName)
            pFeature = pFCursor.NextFeature
        Loop
    End Sub

    Private Sub setDefinitionQuery(categorycode As Integer)
        Dim pSelectedLayer As ILayer = getLayerByName(cmbLayers.SelectedItem.ToString)
        Dim pFLayerDef As IFeatureLayerDefinition = pSelectedLayer
        pFLayerDef.DefinitionExpression = "CATEGORY = " & categorycode
        Dim pMxDoc As IMxDocument = m_application.Document
        pMxDoc.UpdateContents()
        pMxDoc.ActivatedView.Refresh()
    End Sub

    Private Sub cmbLayers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLayers.SelectedIndexChanged
        'get the selected layer
        Dim pSelectedLayer As ILayer = getLayerByName(cmbLayers.SelectedItem.ToString)
        'assume this layer is a feature layer
        Dim pFeatureLayer As IFeatureLayer = pSelectedLayer
        'get the source data, the feature class
        Dim pFeatureClass As IFeatureClass = pFeatureLayer.FeatureClass
        'get the feature cursor to iteratethrough features
        Dim pFeatureCursor As IFeatureCursor = pFeatureClass.Search(Nothing, False)

        PopulateVenues(pFeatureCursor)
    End Sub

End Class