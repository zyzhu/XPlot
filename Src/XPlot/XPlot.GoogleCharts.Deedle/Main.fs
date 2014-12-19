﻿module XPlot.GoogleCharts.Deedle

open XPlot.GoogleCharts
open Deedle
open Deedle.FSharpFrameExtensions

type Chart with

    /// <summary>Creates an area chart.</summary>
    /// <param name="data">The chart's data.</param>
    /// <param name="Labels">Labels for the data table columns.</param>
    /// <param name="Options">The chart's options.</param>
    static member Area(data:Series<'K, 'V>, ?Labels, ?Options) =
        let series =
            data
            |> Series.observations
            |> Seq.map Datum.New
            |> Series.New
        let options = defaultArg Options <| Configuration.Options()
        GoogleChart.Create [series] Labels options Area

    /// <summary>Creates an area chart.</summary>
    /// <param name="data">The chart's data.</param>
    /// <param name="Labels">Labels for the data table columns.</param>
    /// <param name="Options">The chart's options.</param>
    static member Area(data:seq<Series<'K, 'V>> when 'K :> key and 'V :> value, ?Labels, ?Options) =
        let series =
            data
            |> Seq.map (fun x ->
                x 
                |> Series.observations
                |> Seq.map Datum.New
                |> Series.New)
        let options = defaultArg Options <| Configuration.Options()
        GoogleChart.Create series Labels options Area

    /// <summary>Creates an area chart.</summary>
    /// <param name="data">The chart's data.</param>
    /// <param name="Options">The chart's options.</param>
    static member Area(data:Frame<'K, 'V>, ?Options) =
        let dt = data.ToDataTable(["Key"])
        let options = defaultArg Options <| Configuration.Options()
        GoogleChart.CreateFromDataTable dt options Area

    /// <summary>Creates a bar chart.</summary>
    /// <param name="data">The chart's data.</param>
    /// <param name="Labels">Labels for the data table columns.</param>
    /// <param name="Options">The chart's options.</param>
    static member Bar(data:Series<'K, 'V>, ?Labels, ?Options) =
        let series =
            data
            |> Series.observations
            |> Seq.map Datum.New
            |> Series.New
        let options = defaultArg Options <| Configuration.Options()
        GoogleChart.Create [series] Labels options ChartGallery.Bar

    /// <summary>Creates a bar chart.</summary>
    /// <param name="data">The chart's data.</param>
    /// <param name="Labels">Labels for the data table columns.</param>
    /// <param name="Options">The chart's options.</param>
    static member Bar(data:seq<Series<'K, 'V>> when 'K :> key and 'V :> value, ?Labels, ?Options) =
        let series =
            data
            |> Seq.map (fun x ->
                x 
                |> Series.observations
                |> Seq.map Datum.New
                |> Series.New)
        let options = defaultArg Options <| Configuration.Options()
        GoogleChart.Create series Labels options ChartGallery.Bar

    /// <summary>Creates a bar chart.</summary>
    /// <param name="data">The chart's data.</param>
    /// <param name="Options">The chart's options.</param>
    static member Bar(data:Frame<'K, 'V>, ?Options) =
        let dt = data.ToDataTable(["Key"])
        let options = defaultArg Options <| Configuration.Options()
        GoogleChart.CreateFromDataTable dt options ChartGallery.Bar

    /// <summary>Creates a bubble chart.</summary>
    /// <param name="data">The chart's data.</param>
    /// <param name="Options">The chart's options.</param>
    static member Bubble(data:Frame<'K, 'V>, ?Options) =
        let dt = data.ToDataTable(["Key"])
        let options = defaultArg Options <| Configuration.Options()
        GoogleChart.CreateFromDataTable dt options ChartGallery.Bubble

    /// <summary>Creates a calendar chart.</summary>
    /// <param name="data">The chart's data.</param>
    /// <param name="Labels">Labels for the data table columns.</param>
    /// <param name="Options">The chart's options.</param>
    static member Calendar(data:Series<'K, 'V>, ?Labels, ?Options) =
        let series =
            data
            |> Series.observations
            |> Seq.map Datum.New
            |> Series.New
        let options = defaultArg Options <| Configuration.Options()
        GoogleChart.Create [series] Labels options ChartGallery.Calendar

    /// <summary>Creates a candlestick chart.</summary>
    /// <param name="data">The chart's data.</param>
    /// <param name="Options">The chart's options.</param>
    static member Candlestick(data:Frame<'K, 'V>, ?Options) =
        let dt = data.ToDataTable(["Key"])
        let options = defaultArg Options <| Configuration.Options()
        GoogleChart.CreateFromDataTable dt options ChartGallery.Candlestick

    /// <summary>Creates a column chart.</summary>
    /// <param name="data">The chart's data.</param>
    /// <param name="Labels">Labels for the data table columns.</param>
    /// <param name="Options">The chart's options.</param>
    static member Column(data:Series<'K, 'V>, ?Labels, ?Options) =
        let series =
            data
            |> Series.observations
            |> Seq.map Datum.New
            |> Series.New
        let options = defaultArg Options <| Configuration.Options()
        GoogleChart.Create [series] Labels options ChartGallery.Column

    /// <summary>Creates a column chart.</summary>
    /// <param name="data">The chart's data.</param>
    /// <param name="Labels">Labels for the data table columns.</param>
    /// <param name="Options">The chart's options.</param>
    static member Column(data:seq<Series<'K, 'V>> when 'K :> key and 'V :> value, ?Labels, ?Options) =
        let series =
            data
            |> Seq.map (fun x ->
                x 
                |> Series.observations
                |> Seq.map Datum.New
                |> Series.New)
        let options = defaultArg Options <| Configuration.Options()
        GoogleChart.Create series Labels options ChartGallery.Column

    /// <summary>Creates a column chart.</summary>
    /// <param name="data">The chart's data.</param>
    /// <param name="Options">The chart's options.</param>
    static member Column(data:Frame<'K, 'V>, ?Options) =
        let dt = data.ToDataTable(["Key"])
        let options = defaultArg Options <| Configuration.Options()
        GoogleChart.CreateFromDataTable dt options ChartGallery.Column

    /// <summary>Creates a combo chart.</summary>
    /// <param name="data">The chart's data.</param>
    /// <param name="Labels">Labels for the data table columns.</param>
    /// <param name="Options">The chart's options.</param>
    static member Combo(data:seq<Series<'K, 'V>> when 'K :> key and 'V :> value, ?Labels, ?Options) =
        let series =
            data
            |> Seq.map (fun x ->
                x 
                |> Series.observations
                |> Seq.map Datum.New
                |> Series.New)
        let options = defaultArg Options <| Configuration.Options()
        GoogleChart.Create series Labels options ChartGallery.Combo

    /// <summary>Creates a combo chart.</summary>
    /// <param name="data">The chart's data.</param>
    /// <param name="Options">The chart's options.</param>
    static member Combo(data:Frame<'K, 'V>, ?Options) =
        let dt = data.ToDataTable(["Key"])
        let options = defaultArg Options <| Configuration.Options()
        GoogleChart.CreateFromDataTable dt options ChartGallery.Combo

    /// <summary>Creates a gauge chart.</summary>
    /// <param name="data">The chart's data.</param>
    /// <param name="Labels">Labels for the data table columns.</param>
    /// <param name="Options">The chart's options.</param>
    static member Gauge(data:Series<'K, 'V>, ?Labels, ?Options) =
        let series =
            data
            |> Series.observations
            |> Seq.map Datum.New
            |> Series.New
        let options = defaultArg Options <| Configuration.Options()
        GoogleChart.Create [series] Labels options ChartGallery.Gauge

    /// <summary>Creates a geo chart.</summary>
    /// <param name="data">The chart's data.</param>
    /// <param name="Labels">Labels for the data table columns.</param>
    /// <param name="Options">The chart's options.</param>
    static member Geo(data:Series<'K, 'V>, ?Labels, ?Options) =
        let series =
            data
            |> Series.observations
            |> Seq.map Datum.New
            |> Series.New
        let options = defaultArg Options <| Configuration.Options()
        GoogleChart.Create [series] Labels options ChartGallery.Geo

    /// <summary>Creates a geo chart.</summary>
    /// <param name="data">The chart's data.</param>
    /// <param name="Labels">Labels for the data table columns.</param>
    /// <param name="Options">The chart's options.</param>
    static member Geo(data:seq<Series<'K, 'V>> when 'K :> key and 'V :> value, ?Labels, ?Options) =
        let series =
            data
            |> Seq.map (fun x ->
                x 
                |> Series.observations
                |> Seq.map Datum.New
                |> Series.New)
        let options = defaultArg Options <| Configuration.Options()
        GoogleChart.Create series Labels options ChartGallery.Geo

    /// <summary>Creates a geo chart.</summary>
    /// <param name="data">The chart's data.</param>
    /// <param name="Options">The chart's options.</param>
    static member Geo(data:Frame<'K, 'V>, ?Options) =
        let dt = data.ToDataTable(["Key"])
        let options = defaultArg Options <| Configuration.Options()
        GoogleChart.CreateFromDataTable dt options ChartGallery.Geo