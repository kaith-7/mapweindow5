﻿using System;
using System.Collections.Generic;
using System.Drawing.Text;
using MW5.Api.Concrete;
using MW5.Api.Enums;

namespace MW5.Api.Interfaces
{
    public interface ILabelsLayer : ISerializableComWrapper, IDynamicVisibilityTarget
    {
        bool Empty { get; }

        ILabelStyle Style { get; set; }

        LabelStyleList Styles { get; }

        [Obsolete("Use the ApplyCategories method instead")]
        int Generate(string expression, LabelPosition position, bool largestPartOnly = true);

        void ApplyCategories();

        LabelCollection Items { get; }

        bool AutoOffset { get; set; }

        bool AvoidCollisions { get; set; }

        double BasicScale { get; set; }

        int ClassificationField { get; set; }

        int CollisionBuffer { get; set; }

        string Expression { get; set; }

        string FloatNumberFormat { get; set; }

        double OffsetX { get; set; }

        double OffsetY { get; set; }

        int OffsetXField { get; set; }

        int OffsetYField { get; set; }

        LabelPosition Positioning { get; set; }

        bool RemoveDuplicates { get; set; }

        PersistenceType SavingMode { get; set; }

        bool ScaleLabels { get; set; }

        bool Synchronized { get; set; }

        TextRenderingHint TextRenderingHint { get; set; }

        VerticalPosition VerticalPosition { get; set; }

        string VisibilityExpression { get; set; }

        bool Visible { get; set; }

        IEnumerable<LabelInfo> Select(IEnvelope envelope, int tolerance = 0, MapSelectionMode selectMode = MapSelectionMode.Intersection);

        int MinDrawingSize { get; set; }

        bool LogScaleForSize { get; set; }

        bool UseVariableSize { get; set; }

        void UpdateSizeField();

        ILabelStyle GetStyle(GeoLabel lb);

        //void ForceRecalculateExpression();

        //bool LoadFromDbf(bool loadText = false, bool loadCategory = false);

        //bool LoadFromDbf2(string xField = "_LabelX", string yField = "_LabelY", string angleField = "_LabelAngle", string textField = "_LabelText", string categoryField = "_LabelCtg", bool loadText = false, bool loadCategory = false);

        //bool LoadFromXML(string Filename);

        //bool SaveToDbf(bool saveText = false, bool saveCategory = false);

        //bool SaveToDbf2(string xField = "_LabelX", string yField = "_LabelY", string angleField = "_LabelAngle", string textField = "_LabelText", string categoryField = "_LabelCtg", bool saveText = false, bool saveCategory = false);

        //bool SaveToXML(string Filename);
    }
}
