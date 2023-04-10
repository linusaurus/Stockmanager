<?xml version="1.0" encoding="utf-8"?>
<ThermalLabel Version="11.0" Width="2" Height="1" GapLength="0" MarkLength="0" OffsetLength="0" UnitType="Inch" LabelsPerRow="1" LabelsHorizontalGapLength="0" IsContinuous="False" PrintSpeed="" PrintMirror="False" CutAfterPrinting="False" BatchCut="1">
  <Items>
    <RectangleShapeItem X="0.0582" Y="0.0485" Locked="True" Width="1.883" Height="0.8958" />
    <LineShapeItem X="0.0575" Y="0.2475" Width="1.883" Height="0.01" />
    <TextItem X="0.0846" Y="0.0781" PrintAsGraphic="True" Expression="_x0022_Part_x0023__x0020__x0022__x0020__x002B__x0020__x005B_DataFields_x0021_PartID_x005D__x0020_" Width="1.0034" Height="0.1633" Text="Type_x0020_here" Font="Arial,8,Point,,,False,90,,CP850" />
    <TextItem X="0.1042" Y="0.2726" DataField="ItemDescription" PrintAsGraphic="True" Width="1.7986" Height="0.3724" Text="Type_x0020_here" Font="Arial,8,Point,,,False,90,,CP850" TextAlignment="Center" />
    <TextItem X="1.1132" Y="0.0856" PrintAsGraphic="True" Expression="_x0022_Location_x0020_:_x0020__x0022__x0020__x002B__x0020__x005B_DataFields_x0021_Location_x005D_" Width="0.7847" Height="0.1563" Text="Type_x0020_here" Font="Arial,8,Point,,,False,90,,CP850" TextAlignment="Right" />
    <BarcodeItem X="0.1111" Y="0.6737" DataField="PartID" PrintAsGraphic="True" Width="1.7882" Height="0.2309" Symbology="Code39" Code="" BarcodeAlignment="MiddleCenter" CornerRadius="1" DisplayChecksum="False" DisplayStartStopChar="False" Font="NativePrinterFontA,5,Point,,,False,90,,CP850" Sizing="FitProportional" TextFont="NativePrinterFontA,10,Point,,,False,90,,CP850" MaxiCodeDrawPixelBasedSymbol="True" DotCodeAspectRatio="" />
  </Items>
</ThermalLabel>