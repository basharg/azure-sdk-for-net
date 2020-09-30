// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Insights.Models
{
    /// <summary> A rule that provide the triggers and parameters for the scaling action. </summary>
    public partial class ScaleRule
    {
        /// <summary> Initializes a new instance of ScaleRule. </summary>
        /// <param name="metricTrigger"> the trigger that results in a scaling action. </param>
        /// <param name="scaleAction"> the parameters for the scaling action. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metricTrigger"/> or <paramref name="scaleAction"/> is null. </exception>
        public ScaleRule(MetricTrigger metricTrigger, ScaleAction scaleAction)
        {
            if (metricTrigger == null)
            {
                throw new ArgumentNullException(nameof(metricTrigger));
            }
            if (scaleAction == null)
            {
                throw new ArgumentNullException(nameof(scaleAction));
            }

            MetricTrigger = metricTrigger;
            ScaleAction = scaleAction;
        }

        /// <summary> the trigger that results in a scaling action. </summary>
        public MetricTrigger MetricTrigger { get; set; }
        /// <summary> the parameters for the scaling action. </summary>
        public ScaleAction ScaleAction { get; set; }
    }
}