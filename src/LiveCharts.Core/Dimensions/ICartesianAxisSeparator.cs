#region License
// The MIT License (MIT)
// 
// Copyright (c) 2016 Alberto Rodr�guez Orozco & LiveCharts contributors
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy 
// of this software and associated documentation files (the "Software"), to deal 
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies 
// of the Software, and to permit persons to whom the Software is furnished to 
// do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all 
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, 
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES 
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND 
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR 
// OTHER DEALINGS IN THE SOFTWARE.
#endregion
#region

using LiveCharts.Animations;
using LiveCharts.Charts;
using LiveCharts.Drawing.Shapes;
using LiveCharts.Interaction;
using LiveCharts.Interaction.Controls;
using LiveCharts.Interaction.Events;

#endregion

namespace LiveCharts.Dimensions
{
    /// <summary>
    /// Defines a separator view.
    /// </summary>
    public interface IPlaneSeparatorView
    {
        /// <summary>
        /// Gets the label.
        /// </summary>
        /// <value>
        /// The label.
        /// </value>
        object VisualElement { get; }

        /// <summary>
        /// Gets the label.
        /// </summary>
        /// <value>
        /// The label.
        /// </value>
        ILabel Label { get; }

        /// <summary>
        /// Moves the specified point1.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <param name="timeLine">The animation.</param>
        void DrawShape(CartesianAxisSectionArgs args, Transition timeLine);

        /// <summary>
        /// Draws the label.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <param name="timeLine">The animation.</param>
        void DrawLabel(CartesianAxisSectionArgs args, Transition timeLine);

        /// <summary>
        /// Disposes the specified view.
        /// </summary>
        /// <param name="view">The view.</param>
        /// <param name="force">The force</param>
        void Dispose(IChartView view, bool force);
    }
}