﻿' NuGardt Prowl API
' Copyright (C) 2013 NuGardt Software
' http://www.nugardt.com
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
'
Imports System.Xml.Serialization

Namespace Prowl.API
  Partial Class ProwlResult
    ''' <summary>
    ''' Error details.
    ''' </summary>
    ''' <remarks></remarks>
    <XmlRoot(elementName := "error")>
    Public Class ProwlResulterror
      ''' <summary>
      ''' Error code.
      ''' </summary>
      ''' <remarks></remarks>
      <XmlAttribute(attributeName := "code")>
      Public Code As Int16

      ''' <summary>
      ''' Error message.
      ''' </summary>
      ''' <remarks></remarks>
      <XmlText()>
      Public Message As String

      ''' <summary>
      ''' Constructor.
      ''' </summary>
      ''' <remarks></remarks>
      Public Sub New()
        Me.Code = Nothing
        Me.Message = Nothing
      End Sub
    End Class
  End Class
End Namespace