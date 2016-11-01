Imports ESRI.ArcGIS.Framework
Imports ESRI.ArcGIS.Carto
Imports ESRI.ArcGIS.ArcMapUI

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
        Try

            Dim pMxDoc As IMxDocument = m_application.Document
            Dim pMap As IMap = pMxDoc.FocusMap
            For i As Integer = 0 To pMap.LayerCount - 1
                Dim pLayer As ILayer = pMap.Layer(i)

                If pLayer.Name = sLayerName Then
                    Return pLayer
                End If
            Next
            Return Nothing
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try


    End Function

    Private Sub btnRestaurants_Click(sender As Object, e As EventArgs) Handles btnRestaurants.Click, btnBars.Click, btnCafes, btnDiners, btnLounges
        Dim pButton As Windows.Forms.Button = sender

        setDefinitionQuery(pButton.Tag)


    End Sub



    Private Function setDefinitionQuery(categorycode As Integer)
        Dim pSelectedLayer As ILayer = getLayerByName(cmbLayers.SelectedItem.ToString)
        Dim pFLayerDef As IFeatureLayerDefinition = pSelectedLayer
        pFLayerDef.DefinitionExpression = "CATEGORY = " & categorycode
        Dim pMxDoc As IMxDocument = m_application.Document
        pMxDoc.UpdateContents()
        pMxDoc.ActivatedView.Refresh()
    End Function
End Class