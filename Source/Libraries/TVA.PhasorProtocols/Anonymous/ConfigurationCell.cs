//******************************************************************************************************
//  ConfigurationCell.cs - Gbtc
//
//  Copyright © 2010, Grid Protection Alliance.  All Rights Reserved.
//
//  Licensed to the Grid Protection Alliance (GPA) under one or more contributor license agreements. See
//  the NOTICE file distributed with this work for additional information regarding copyright ownership.
//  The GPA licenses this file to you under the Eclipse Public License -v 1.0 (the "License"); you may
//  not use this file except in compliance with the License. You may obtain a copy of the License at:
//
//      http://www.opensource.org/licenses/eclipse-1.0.php
//
//  Unless agreed to in writing, the subject software distributed under the License is distributed on an
//  "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
//  License for the specific language governing permissions and limitations.
//
//  Code Modification History:
//  ----------------------------------------------------------------------------------------------------
//  05/05/2009 - J. Ritchie Carroll
//       Generated original version of source code.
//  05/19/2011 - J. Ritchie Carroll
//       Removed generic dictionary from serialization since these can't be SOAP serialized.
//
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TVA.PhasorProtocols.Anonymous
{
    /// <summary>
    /// Represents a protocol independent implementation of a <see cref="IConfigurationCell"/> that can be sent or received.
    /// </summary>
    [Serializable()]
    public class ConfigurationCell : ConfigurationCellBase, IDisposable
    {
        #region [ Members ]

        // Events

        /// <summary>
        /// Event is raised when <see cref="ConfigurationCell"/> is disposed.
        /// </summary>
        public event EventHandler Disposed;

        // Fields
        private DataFormat m_analogDataFormat;
        private DataFormat m_frequencyDataFormat;
        private DataFormat m_phasorDataFormat;
        private CoordinateFormat m_phasorCoordinateFormat;

        // We add cached signal type and statistical tracking information to our protocol independent configuration cell
        private Dictionary<SignalKind, string[]> m_generatedSignalReferenceCache;
        private Ticks m_lastReportTime;
        private long m_totalFrames;
        private long m_dataQualityErrors;
        private long m_timeQualityErrors;
        private long m_deviceErrors;
        private object m_source;
        private bool m_disposed;

        #endregion

        #region [ Constructors ]

        /// <summary>
        /// Creates a new <see cref="ConfigurationCell"/> from specified parameters.
        /// </summary>
        /// <param name="idCode">The numeric ID code for this <see cref="ConfigurationCell"/>.</param>
        public ConfigurationCell(ushort idCode)
            : this(null, idCode)
        {
        }

        /// <summary>
        /// Creates a new <see cref="ConfigurationCell"/> from specified parameters.
        /// </summary>
        /// <param name="parent">The reference to parent <see cref="ConfigurationFrame"/> of this <see cref="ConfigurationCell"/>.</param>
        /// <param name="idCode">The numeric ID code for this <see cref="ConfigurationCell"/>.</param>
        public ConfigurationCell(ConfigurationFrame parent, ushort idCode)
            : base(parent, idCode, int.MaxValue, int.MaxValue, int.MaxValue)
        {
            m_generatedSignalReferenceCache = new Dictionary<SignalKind, string[]>();
            m_analogDataFormat = DataFormat.FloatingPoint;
            m_frequencyDataFormat = DataFormat.FloatingPoint;
            m_phasorDataFormat = DataFormat.FloatingPoint;
            m_phasorCoordinateFormat = CoordinateFormat.Polar;
        }

        /// <summary>
        /// Creates a new <see cref="ConfigurationCell"/> from serialization parameters.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> with populated with data.</param>
        /// <param name="context">The source <see cref="StreamingContext"/> for this deserialization.</param>
        protected ConfigurationCell(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            // Deserialize configuration cell
            m_generatedSignalReferenceCache = new Dictionary<SignalKind, string[]>();
            m_lastReportTime = info.GetInt64("lastReportTime");
            m_analogDataFormat = (DataFormat)info.GetValue("analogDataFormat", typeof(DataFormat));
            m_frequencyDataFormat = (DataFormat)info.GetValue("frequencyDataFormat", typeof(DataFormat));
            m_phasorDataFormat = (DataFormat)info.GetValue("phasorDataFormat", typeof(DataFormat));
            m_phasorCoordinateFormat = (CoordinateFormat)info.GetValue("phasorCoordinateFormat", typeof(CoordinateFormat));
        }

        /// <summary>
        /// Releases the unmanaged resources before the <see cref="ConfigurationCell"/> object is reclaimed by <see cref="GC"/>.
        /// </summary>
        ~ConfigurationCell()
        {
            Dispose(false);
        }

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Gets or sets the <see cref="DataFormat"/> for the <see cref="IAnalogDefinition"/> objects in the <see cref="ConfigurationCellBase.AnalogDefinitions"/> of this <see cref="ConfigurationCell"/>.
        /// </summary>
        public override DataFormat AnalogDataFormat
        {
            get
            {
                return m_analogDataFormat;
            }
            set
            {
                m_analogDataFormat = value;
            }
        }

        /// <summary>
        /// Gets or sets the <see cref="DataFormat"/> of the <see cref="FrequencyDefinition"/> of this <see cref="ConfigurationCell"/>.
        /// </summary>
        public override DataFormat FrequencyDataFormat
        {
            get
            {
                return m_frequencyDataFormat;
            }
            set
            {
                m_frequencyDataFormat = value;
            }
        }

        /// <summary>
        /// Gets or sets the <see cref="DataFormat"/> for the <see cref="IPhasorDefinition"/> objects in the <see cref="ConfigurationCellBase.PhasorDefinitions"/> of this <see cref="ConfigurationCell"/>.
        /// </summary>
        public override DataFormat PhasorDataFormat
        {
            get
            {
                return m_phasorDataFormat;
            }
            set
            {
                m_phasorDataFormat = value;
            }
        }

        /// <summary>
        /// Gets or sets the <see cref="CoordinateFormat"/> for the <see cref="IPhasorDefinition"/> objects in the <see cref="ConfigurationCellBase.PhasorDefinitions"/> of this <see cref="ConfigurationCell"/>.
        /// </summary>
        public override CoordinateFormat PhasorCoordinateFormat
        {
            get
            {
                return m_phasorCoordinateFormat;
            }
            set
            {
                m_phasorCoordinateFormat = value;
            }
        }

        /// <summary>
        /// Gets or sets last report time of this <see cref="ConfigurationCell"/>.
        /// </summary>
        public Ticks LastReportTime
        {
            get
            {
                return m_lastReportTime;
            }
            set
            {
                m_lastReportTime = value;
            }
        }

        /// <summary>
        /// Gets or sets total frames of this <see cref="ConfigurationCell"/>.
        /// </summary>
        public long TotalFrames
        {
            get
            {
                return m_totalFrames;
            }
            set
            {
                m_totalFrames = value;
            }
        }

        /// <summary>
        /// Gets or sets total data quality errors of this <see cref="ConfigurationCell"/>.
        /// </summary>
        public long DataQualityErrors
        {
            get
            {
                return m_dataQualityErrors;
            }
            set
            {
                m_dataQualityErrors = value;
            }
        }

        /// <summary>
        /// Gets or sets total time quality errors of this <see cref="ConfigurationCell"/>.
        /// </summary>
        public long TimeQualityErrors
        {
            get
            {
                return m_timeQualityErrors;
            }
            set
            {
                m_timeQualityErrors = value;
            }
        }

        /// <summary>
        /// Gets or sets total device errors of this <see cref="ConfigurationCell"/>.
        /// </summary>
        public long DeviceErrors
        {
            get
            {
                return m_deviceErrors;
            }
            set
            {
                m_deviceErrors = value;
            }
        }

        /// <summary>
        /// Gets or sets the reference to the source of this <see cref="ConfigurationCell"/>.
        /// </summary>
        public object Source
        {
            get
            {
                return m_source;
            }
            set
            {
                m_source = value;
            }
        }

        #endregion

        #region [ Methods ]

        /// <summary>
        /// Releases all the resources used by the <see cref="ConfigurationCell"/> object.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="ConfigurationCell"/> object and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!m_disposed)
            {
                try
                {
                    if (disposing)
                    {
                        if (m_generatedSignalReferenceCache != null)
                            m_generatedSignalReferenceCache.Clear();

                        m_generatedSignalReferenceCache = null;
                    }
                }
                finally
                {
                    m_disposed = true;  // Prevent duplicate dispose.

                    if (Disposed != null)
                        Disposed(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Get signal reference for specified <see cref="SignalKind"/>.
        /// </summary>
        /// <param name="type"><see cref="SignalKind"/> to request signal reference for.</param>
        /// <returns>Signal reference of given <see cref="SignalKind"/>.</returns>
        public string GetSignalReference(SignalKind type)
        {
            // We cache non-indexed signal reference strings so they don't need to be generated at each mapping call.
            // This helps with performance since the mappings for each signal occur 30 times per second.
            string[] references;

            // Look up synonym in dictionary based on signal type, if found return single element
            if (m_generatedSignalReferenceCache.TryGetValue(type, out references))
                return references[0];

            // Create a new signal reference array (for single element)
            references = new string[1];

            // Create and cache new non-indexed signal reference
            references[0] = SignalReference.ToString(IDLabel, type);

            // Cache generated signal synonym
            m_generatedSignalReferenceCache.Add(type, references);

            return references[0];
        }

        /// <summary>
        /// Get signal reference for specified <see cref="SignalKind"/> and <paramref name="index"/>.
        /// </summary>
        /// <param name="type"><see cref="SignalKind"/> to request signal reference for.</param>
        /// <param name="index">Index <see cref="SignalKind"/> to request signal reference for.</param>
        /// <param name="count">Number of signals defined for this <see cref="SignalKind"/>.</param>
        /// <returns>Signal reference of given <see cref="SignalKind"/> and <paramref name="index"/>.</returns>
        public string GetSignalReference(SignalKind type, int index, int count)
        {
            // We cache indexed signal reference strings so they don't need to be generated at each mapping call.
            // This helps with performance since the mappings for each signal occur 30 times per second.
            // For speed purposes we intentionally do not validate that signalIndex falls within signalCount, be
            // sure calling procedures are very careful with parameters...
            string[] references;

            // Look up synonym in dictionary based on signal type
            if (m_generatedSignalReferenceCache.TryGetValue(type, out references))
            {
                // Verify signal count has not changed (we may have received new configuration from device)
                if (count == references.Length)
                {
                    // Create and cache new signal reference if it doesn't exist
                    if (references[index] == null)
                        references[index] = SignalReference.ToString(IDLabel, type, index + 1);

                    return references[index];
                }
            }

            // Create a new indexed signal reference array
            references = new string[count];

            // Create and cache new signal reference
            references[index] = SignalReference.ToString(IDLabel, type, index + 1);

            // Cache generated signal synonym array
            m_generatedSignalReferenceCache.Add(type, references);

            return references[index];
        }

        /// <summary>
        /// Populates a <see cref="SerializationInfo"/> with the data needed to serialize the target object.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> to populate with data.</param>
        /// <param name="context">The destination <see cref="StreamingContext"/> for this serialization.</param>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            // Serialize configuration cell
            info.AddValue("lastReportTime", (long)m_lastReportTime);
            info.AddValue("analogDataFormat", m_analogDataFormat, typeof(DataFormat));
            info.AddValue("frequencyDataFormat", m_frequencyDataFormat, typeof(DataFormat));
            info.AddValue("phasorDataFormat", m_phasorDataFormat, typeof(DataFormat));
            info.AddValue("phasorCoordinateFormat", m_phasorCoordinateFormat, typeof(CoordinateFormat));
        }

        #endregion
    }
}