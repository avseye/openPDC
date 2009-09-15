//*******************************************************************************************************
//  FrameParserBase.cs - Gbtc
//
//  Tennessee Valley Authority, 2009
//  No copyright is claimed pursuant to 17 USC § 105.  All Other Rights Reserved.
//
//  This software is made freely available under the TVA Open Source Agreement (see below).
//
//  Code Modification History:
//  -----------------------------------------------------------------------------------------------------
//  02/12/2007 - J. Ritchie Carroll
//       Generated original version of source code.
//  12/16/2008 - J. Ritchie Carroll
//       Converted class to inherit from FrameImageParserBase.
//  08/07/2009 - Josh L. Patterson
//       Edited Comments.
//  09/15/2009 - Stephen C. Wills
//       Added new header and license agreement.
//
//*******************************************************************************************************

#region [ TVA Open Source Agreement ]
/*

 THIS OPEN SOURCE AGREEMENT ("AGREEMENT") DEFINES THE RIGHTS OF USE,REPRODUCTION, DISTRIBUTION,
 MODIFICATION AND REDISTRIBUTION OF CERTAIN COMPUTER SOFTWARE ORIGINALLY RELEASED BY THE
 TENNESSEE VALLEY AUTHORITY, A CORPORATE AGENCY AND INSTRUMENTALITY OF THE UNITED STATES GOVERNMENT
 ("GOVERNMENT AGENCY"). GOVERNMENT AGENCY IS AN INTENDED THIRD-PARTY BENEFICIARY OF ALL SUBSEQUENT
 DISTRIBUTIONS OR REDISTRIBUTIONS OF THE SUBJECT SOFTWARE. ANYONE WHO USES, REPRODUCES, DISTRIBUTES,
 MODIFIES OR REDISTRIBUTES THE SUBJECT SOFTWARE, AS DEFINED HEREIN, OR ANY PART THEREOF, IS, BY THAT
 ACTION, ACCEPTING IN FULL THE RESPONSIBILITIES AND OBLIGATIONS CONTAINED IN THIS AGREEMENT.

 Original Software Designation: openPDC
 Original Software Title: The TVA Open Source Phasor Data Concentrator
 User Registration Requested. Please Visit https://naspi.tva.com/Registration/
 Point of Contact for Original Software: J. Ritchie Carroll <mailto:jrcarrol@tva.gov>

 1. DEFINITIONS

 A. "Contributor" means Government Agency, as the developer of the Original Software, and any entity
 that makes a Modification.

 B. "Covered Patents" mean patent claims licensable by a Contributor that are necessarily infringed by
 the use or sale of its Modification alone or when combined with the Subject Software.

 C. "Display" means the showing of a copy of the Subject Software, either directly or by means of an
 image, or any other device.

 D. "Distribution" means conveyance or transfer of the Subject Software, regardless of means, to
 another.

 E. "Larger Work" means computer software that combines Subject Software, or portions thereof, with
 software separate from the Subject Software that is not governed by the terms of this Agreement.

 F. "Modification" means any alteration of, including addition to or deletion from, the substance or
 structure of either the Original Software or Subject Software, and includes derivative works, as that
 term is defined in the Copyright Statute, 17 USC § 101. However, the act of including Subject Software
 as part of a Larger Work does not in and of itself constitute a Modification.

 G. "Original Software" means the computer software first released under this Agreement by Government
 Agency entitled openPDC, including source code, object code and accompanying documentation, if any.

 H. "Recipient" means anyone who acquires the Subject Software under this Agreement, including all
 Contributors.

 I. "Redistribution" means Distribution of the Subject Software after a Modification has been made.

 J. "Reproduction" means the making of a counterpart, image or copy of the Subject Software.

 K. "Sale" means the exchange of the Subject Software for money or equivalent value.

 L. "Subject Software" means the Original Software, Modifications, or any respective parts thereof.

 M. "Use" means the application or employment of the Subject Software for any purpose.

 2. GRANT OF RIGHTS

 A. Under Non-Patent Rights: Subject to the terms and conditions of this Agreement, each Contributor,
 with respect to its own contribution to the Subject Software, hereby grants to each Recipient a
 non-exclusive, world-wide, royalty-free license to engage in the following activities pertaining to
 the Subject Software:

 1. Use

 2. Distribution

 3. Reproduction

 4. Modification

 5. Redistribution

 6. Display

 B. Under Patent Rights: Subject to the terms and conditions of this Agreement, each Contributor, with
 respect to its own contribution to the Subject Software, hereby grants to each Recipient under Covered
 Patents a non-exclusive, world-wide, royalty-free license to engage in the following activities
 pertaining to the Subject Software:

 1. Use

 2. Distribution

 3. Reproduction

 4. Sale

 5. Offer for Sale

 C. The rights granted under Paragraph B. also apply to the combination of a Contributor's Modification
 and the Subject Software if, at the time the Modification is added by the Contributor, the addition of
 such Modification causes the combination to be covered by the Covered Patents. It does not apply to
 any other combinations that include a Modification. 

 D. The rights granted in Paragraphs A. and B. allow the Recipient to sublicense those same rights.
 Such sublicense must be under the same terms and conditions of this Agreement.

 3. OBLIGATIONS OF RECIPIENT

 A. Distribution or Redistribution of the Subject Software must be made under this Agreement except for
 additions covered under paragraph 3H. 

 1. Whenever a Recipient distributes or redistributes the Subject Software, a copy of this Agreement
 must be included with each copy of the Subject Software; and

 2. If Recipient distributes or redistributes the Subject Software in any form other than source code,
 Recipient must also make the source code freely available, and must provide with each copy of the
 Subject Software information on how to obtain the source code in a reasonable manner on or through a
 medium customarily used for software exchange.

 B. Each Recipient must ensure that the following copyright notice appears prominently in the Subject
 Software:

          No copyright is claimed pursuant to 17 USC § 105.  All Other Rights Reserved.

 C. Each Contributor must characterize its alteration of the Subject Software as a Modification and
 must identify itself as the originator of its Modification in a manner that reasonably allows
 subsequent Recipients to identify the originator of the Modification. In fulfillment of these
 requirements, Contributor must include a file (e.g., a change log file) that describes the alterations
 made and the date of the alterations, identifies Contributor as originator of the alterations, and
 consents to characterization of the alterations as a Modification, for example, by including a
 statement that the Modification is derived, directly or indirectly, from Original Software provided by
 Government Agency. Once consent is granted, it may not thereafter be revoked.

 D. A Contributor may add its own copyright notice to the Subject Software. Once a copyright notice has
 been added to the Subject Software, a Recipient may not remove it without the express permission of
 the Contributor who added the notice.

 E. A Recipient may not make any representation in the Subject Software or in any promotional,
 advertising or other material that may be construed as an endorsement by Government Agency or by any
 prior Recipient of any product or service provided by Recipient, or that may seek to obtain commercial
 advantage by the fact of Government Agency's or a prior Recipient's participation in this Agreement.

 F. In an effort to track usage and maintain accurate records of the Subject Software, each Recipient,
 upon receipt of the Subject Software, is requested to register with Government Agency by visiting the
 following website: https://naspi.tva.com/Registration/. Recipient's name and personal information
 shall be used for statistical purposes only. Once a Recipient makes a Modification available, it is
 requested that the Recipient inform Government Agency at the web site provided above how to access the
 Modification.

 G. Each Contributor represents that that its Modification does not violate any existing agreements,
 regulations, statutes or rules, and further that Contributor has sufficient rights to grant the rights
 conveyed by this Agreement.

 H. A Recipient may choose to offer, and to charge a fee for, warranty, support, indemnity and/or
 liability obligations to one or more other Recipients of the Subject Software. A Recipient may do so,
 however, only on its own behalf and not on behalf of Government Agency or any other Recipient. Such a
 Recipient must make it absolutely clear that any such warranty, support, indemnity and/or liability
 obligation is offered by that Recipient alone. Further, such Recipient agrees to indemnify Government
 Agency and every other Recipient for any liability incurred by them as a result of warranty, support,
 indemnity and/or liability offered by such Recipient.

 I. A Recipient may create a Larger Work by combining Subject Software with separate software not
 governed by the terms of this agreement and distribute the Larger Work as a single product. In such
 case, the Recipient must make sure Subject Software, or portions thereof, included in the Larger Work
 is subject to this Agreement.

 J. Notwithstanding any provisions contained herein, Recipient is hereby put on notice that export of
 any goods or technical data from the United States may require some form of export license from the
 U.S. Government. Failure to obtain necessary export licenses may result in criminal liability under
 U.S. laws. Government Agency neither represents that a license shall not be required nor that, if
 required, it shall be issued. Nothing granted herein provides any such export license.

 4. DISCLAIMER OF WARRANTIES AND LIABILITIES; WAIVER AND INDEMNIFICATION

 A. No Warranty: THE SUBJECT SOFTWARE IS PROVIDED "AS IS" WITHOUT ANY WARRANTY OF ANY KIND, EITHER
 EXPRESSED, IMPLIED, OR STATUTORY, INCLUDING, BUT NOT LIMITED TO, ANY WARRANTY THAT THE SUBJECT
 SOFTWARE WILL CONFORM TO SPECIFICATIONS, ANY IMPLIED WARRANTIES OF MERCHANTABILITY, FITNESS FOR A
 PARTICULAR PURPOSE, OR FREEDOM FROM INFRINGEMENT, ANY WARRANTY THAT THE SUBJECT SOFTWARE WILL BE ERROR
 FREE, OR ANY WARRANTY THAT DOCUMENTATION, IF PROVIDED, WILL CONFORM TO THE SUBJECT SOFTWARE. THIS
 AGREEMENT DOES NOT, IN ANY MANNER, CONSTITUTE AN ENDORSEMENT BY GOVERNMENT AGENCY OR ANY PRIOR
 RECIPIENT OF ANY RESULTS, RESULTING DESIGNS, HARDWARE, SOFTWARE PRODUCTS OR ANY OTHER APPLICATIONS
 RESULTING FROM USE OF THE SUBJECT SOFTWARE. FURTHER, GOVERNMENT AGENCY DISCLAIMS ALL WARRANTIES AND
 LIABILITIES REGARDING THIRD-PARTY SOFTWARE, IF PRESENT IN THE ORIGINAL SOFTWARE, AND DISTRIBUTES IT
 "AS IS."

 B. Waiver and Indemnity: RECIPIENT AGREES TO WAIVE ANY AND ALL CLAIMS AGAINST GOVERNMENT AGENCY, ITS
 AGENTS, EMPLOYEES, CONTRACTORS AND SUBCONTRACTORS, AS WELL AS ANY PRIOR RECIPIENT. IF RECIPIENT'S USE
 OF THE SUBJECT SOFTWARE RESULTS IN ANY LIABILITIES, DEMANDS, DAMAGES, EXPENSES OR LOSSES ARISING FROM
 SUCH USE, INCLUDING ANY DAMAGES FROM PRODUCTS BASED ON, OR RESULTING FROM, RECIPIENT'S USE OF THE
 SUBJECT SOFTWARE, RECIPIENT SHALL INDEMNIFY AND HOLD HARMLESS  GOVERNMENT AGENCY, ITS AGENTS,
 EMPLOYEES, CONTRACTORS AND SUBCONTRACTORS, AS WELL AS ANY PRIOR RECIPIENT, TO THE EXTENT PERMITTED BY
 LAW.  THE FOREGOING RELEASE AND INDEMNIFICATION SHALL APPLY EVEN IF THE LIABILITIES, DEMANDS, DAMAGES,
 EXPENSES OR LOSSES ARE CAUSED, OCCASIONED, OR CONTRIBUTED TO BY THE NEGLIGENCE, SOLE OR CONCURRENT, OF
 GOVERNMENT AGENCY OR ANY PRIOR RECIPIENT.  RECIPIENT'S SOLE REMEDY FOR ANY SUCH MATTER SHALL BE THE
 IMMEDIATE, UNILATERAL TERMINATION OF THIS AGREEMENT.

 5. GENERAL TERMS

 A. Termination: This Agreement and the rights granted hereunder will terminate automatically if a
 Recipient fails to comply with these terms and conditions, and fails to cure such noncompliance within
 thirty (30) days of becoming aware of such noncompliance. Upon termination, a Recipient agrees to
 immediately cease use and distribution of the Subject Software. All sublicenses to the Subject
 Software properly granted by the breaching Recipient shall survive any such termination of this
 Agreement.

 B. Severability: If any provision of this Agreement is invalid or unenforceable under applicable law,
 it shall not affect the validity or enforceability of the remainder of the terms of this Agreement.

 C. Applicable Law: This Agreement shall be subject to United States federal law only for all purposes,
 including, but not limited to, determining the validity of this Agreement, the meaning of its
 provisions and the rights, obligations and remedies of the parties.

 D. Entire Understanding: This Agreement constitutes the entire understanding and agreement of the
 parties relating to release of the Subject Software and may not be superseded, modified or amended
 except by further written agreement duly executed by the parties.

 E. Binding Authority: By accepting and using the Subject Software under this Agreement, a Recipient
 affirms its authority to bind the Recipient to all terms and conditions of this Agreement and that
 Recipient hereby agrees to all terms and conditions herein.

 F. Point of Contact: Any Recipient contact with Government Agency is to be directed to the designated
 representative as follows: J. Ritchie Carroll <mailto:jrcarrol@tva.gov>.

*/
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using TVA.Collections;
using TVA.Parsing;

namespace TVA.PhasorProtocols
{
    /// <summary>
    /// Represents a frame parser that defines the basic functionality for a protocol to parse a binary data stream and return the parsed data via events.
    /// </summary>
    /// <remarks>
    /// Frame parsers are implemented as a write-only streams so that data can come from any source.<br/>
    /// See <see cref="FrameImageParserBase{TFrameIdentifier, TCommonFrameHeader}"/> for more detail.
    /// </remarks>
    /// <typeparam name="TFrameIdentifier">Frame type identifier used to distinguish frames.</typeparam>
    public abstract class FrameParserBase<TFrameIdentifier> : FrameImageParserBase<TFrameIdentifier, ISupportFrameImage<TFrameIdentifier>>, IFrameParser
    {
        #region [ Members ]

        // Events

        // Derived classes will typically also expose events to provide instances to the protocol specific final derived channel frames

        /// <summary>
        /// Occurs when a <see cref="IConfigurationFrame"/> has been received.
        /// </summary>
        /// <remarks>
        /// <see cref="EventArgs{T}.Argument"/> is the <see cref="IConfigurationFrame"/> that was received.
        /// </remarks>
        public event EventHandler<EventArgs<IConfigurationFrame>> ReceivedConfigurationFrame;

        /// <summary>
        /// Occurs when a <see cref="IDataFrame"/> has been received.
        /// </summary>
        /// <remarks>
        /// <see cref="EventArgs{T}.Argument"/> is the <see cref="IDataFrame"/> that was received.
        /// </remarks>
        public event EventHandler<EventArgs<IDataFrame>> ReceivedDataFrame;

        /// <summary>
        /// Occurs when a <see cref="IHeaderFrame"/> has been received.
        /// </summary>
        /// <remarks>
        /// <see cref="EventArgs{T}.Argument"/> is the <see cref="IHeaderFrame"/> that was received.
        /// </remarks>
        public event EventHandler<EventArgs<IHeaderFrame>> ReceivedHeaderFrame;

        /// <summary>
        /// Occurs when a <see cref="ICommandFrame"/> has been received.
        /// </summary>
        /// <remarks>
        /// <see cref="EventArgs{T}.Argument"/> is the <see cref="ICommandFrame"/> that was received.
        /// <para>
        /// Command frames are normally sent, not received, but there is nothing that prevents this.
        /// </para>
        /// </remarks>
        public event EventHandler<EventArgs<ICommandFrame>> ReceivedCommandFrame;

        /// <summary>
        /// Occurs when an undetermined <see cref="IChannelFrame"/> has been received.
        /// </summary>
        /// <remarks>
        /// <see cref="EventArgs{T}.Argument"/> is the undetermined <see cref="IChannelFrame"/> that was received.
        /// </remarks>
        public event EventHandler<EventArgs<IChannelFrame>> ReceivedUndeterminedFrame;

        /// <summary>
        /// Occurs when a frame buffer image has been received.
        /// </summary>
        /// <remarks>
        /// <see cref="EventArgs{T1,T2,T3,T4}.Argument1"/> is the <see cref="FundamentalFrameType"/> of the frame buffer image that was received.<br/>
        /// <see cref="EventArgs{T1,T2,T3,T4}.Argument2"/> is the buffer that contains the frame image that was received.<br/>
        /// <see cref="EventArgs{T1,T2,T3,T4}.Argument3"/> is the offset into the buffer that contains the frame image that was received.<br/>
        /// <see cref="EventArgs{T1,T2,T3,T4}.Argument4"/> is the length of data in the buffer that contains the frame image that was received..
        /// </remarks>
        public event EventHandler<EventArgs<FundamentalFrameType, byte[], int, int>> ReceivedFrameBufferImage;

        /// <summary>
        /// Occurs when a device sends a notification that its configuration has changed.
        /// </summary>
        public event EventHandler ConfigurationChanged;

        // Fields
        private ProcessQueue<byte[]> m_bufferQueue;
        private IConnectionParameters m_connectionParameters;
        private bool m_disposed;

        #endregion

        #region [ Constructors ]

        /// <summary>
        /// Creates a new <see cref="FrameParserBase{TypeIndentifier}"/>.
        /// </summary>
        protected FrameParserBase()
        {
            // We attach to base class DataParsed event to automatically redirect and cast channel frames to their specific output events
            base.DataParsed += base_DataParsed;
        }

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Gets or sets a flag that allows frame parsing to be executed on a separate thread (i.e., other than communications thread).
        /// </summary>
        /// <remarks>
        /// This is typically only needed when data frames are very large. This change will happen dynamically, even if a connection is active.
        /// </remarks>
        public virtual bool ExecuteParseOnSeparateThread
        {
            get
            {
                return (m_bufferQueue != null);
            }
            set
            {
                // This property allows a dynamic change in state of how to process streaming data
                if (value)
                {
                    if (m_bufferQueue == null)
                    {
                        m_bufferQueue = CreateBufferQueue();
                        m_bufferQueue.ProcessException += m_bufferQueue_ProcessException;
                    }

                    if (Enabled && !m_bufferQueue.Enabled)
                        m_bufferQueue.Start();
                }
                else
                {
                    if (m_bufferQueue != null)
                    {
                        m_bufferQueue.Stop();
                        m_bufferQueue.ProcessException -= m_bufferQueue_ProcessException;
                    }

                    m_bufferQueue = null;
                }
            }
        }

        /// <summary>
        /// Gets the total number of buffers that are currently queued for processing, if any.
        /// </summary>
        public virtual int QueuedBuffers
        {
            get
            {
                if (m_bufferQueue == null)
                    return 0;
                else
                    return m_bufferQueue.Count;
            }
        }

        /// <summary>
        /// Gets or sets current <see cref="IConfigurationFrame"/> used for parsing <see cref="IDataFrame"/>'s encountered in the data stream from a device.
        /// </summary>
        /// <remarks>
        /// If a <see cref="IConfigurationFrame"/> has been parsed, this will return a reference to the parsed frame.  Consumer can manually assign a
        /// <see cref="IConfigurationFrame"/> to start parsing data if one has not been encountered in the stream.
        /// </remarks>
        public abstract IConfigurationFrame ConfigurationFrame { get; set; }

        /// <summary>
        /// Gets or sets any connection specific <see cref="IConnectionParameters"/> that may be needed for parsing.
        /// </summary>
        public virtual IConnectionParameters ConnectionParameters
        {
            get
            {
                return m_connectionParameters;
            }
            set
            {
                m_connectionParameters = value;
            }
        }

        /// <summary>
        /// Gets current descriptive status of the <see cref="FrameParserBase{TypeIndentifier}"/>.
        /// </summary>
        public override string Status
        {
            get
            {
                StringBuilder status = new StringBuilder();
                status.Append(base.Status);
                status.Append("     Received config frame: ");
                status.Append(ConfigurationFrame == null ? "No" : "Yes");
                status.AppendLine();
                if (ConfigurationFrame != null)
                {
                    status.Append("   Devices in config frame: ");
                    status.Append(ConfigurationFrame.Cells.Count);
                    status.Append(" total - ");
                    status.AppendLine();
                    for (int x = 0; x < ConfigurationFrame.Cells.Count; x++)
                    {
                        status.Append("               (");
                        status.Append(ConfigurationFrame.Cells[x].IDCode);
                        status.Append(") ");
                        status.Append(ConfigurationFrame.Cells[x].StationName);
                        status.AppendLine();
                    }
                    status.Append("     Configured frame rate: ");
                    status.Append(ConfigurationFrame.FrameRate);
                    status.AppendLine();
                }
                status.Append("  Parsing execution source: ");
                if (m_bufferQueue == null)
                {
                    status.Append("Communications thread");
                    status.AppendLine();
                }
                else
                {
                    status.Append("Independent thread using queued data");
                    status.AppendLine();
                    status.Append(m_bufferQueue.Status);
                }

                return status.ToString();
            }
        }

        #endregion

        #region [ Methods ]

        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="FrameParserBase{TypeIndentifier}"/> object and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (!m_disposed)
            {
                try
                {
                    if (disposing)
                    {
                        if (m_bufferQueue != null)
                        {
                            m_bufferQueue.ProcessException -= m_bufferQueue_ProcessException;
                            m_bufferQueue.Dispose();
                        }
                        m_bufferQueue = null;

                        // Detach from base class events
                        base.DataParsed -= base_DataParsed;
                    }
                }
                finally
                {
                    base.Dispose(disposing);    // Call base class Dispose().
                    m_disposed = true;          // Prevent duplicate dispose.
                }
            }
        }

        /// <summary>
        /// Starts the frame parser given the specified type implementations.
        /// </summary>
        /// <param name="implementations">An implementation type paramater.</param>
        public override void Start(IEnumerable<Type> implementations)
        {
            base.Start(implementations);

            if (m_bufferQueue != null)
                m_bufferQueue.Start();
        }

        /// <summary>
        /// Stops the frame parser.
        /// </summary>
        public override void Stop()
        {
            base.Stop();

            if (m_bufferQueue != null)
                m_bufferQueue.Stop();
        }

        /// <summary>
        /// Writes a sequence of bytes onto the stream for parsing.
        /// </summary>
        /// <param name="buffer">An array of bytes. This method copies count bytes from buffer to the current stream.</param>
        /// <param name="offset">The zero-based byte offset in buffer at which to begin copying bytes to the current stream.</param>
        /// <param name="count">The number of bytes to be written to the current stream.</param>
        public override void Write(byte[] buffer, int offset, int count)
        {
            if (m_bufferQueue == null)
                // Directly parse frame using calling thread (typically communications thread)
                base.Write(buffer, offset, count);
            else
                // Queue up received data buffer for real-time parsing and return to data collection as quickly as possible...
                m_bufferQueue.Add(buffer.BlockCopy(offset, count));
        }

        /// <summary>
        /// Clears all buffers for this stream and causes any buffered data to be parsed immediately.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method is only relevant when <see cref="ExecuteParseOnSeparateThread"/> is true; otherwise this method has no effect.
        /// </para>
        /// <para>
        /// If the user has called <see cref="Start"/> method, this method will process all remaining buffers on the calling thread
        /// until all queued buffers have been parsed - the <see cref="FrameParserBase{TFrameIdentifier}"/> will then be automatically
        /// stopped. This method is typically called on shutdown to make sure any remaining queued buffers get parsed before the class
        /// instance is destructed.
        /// </para>
        /// <para>
        /// It is possible for items to be queued while the flush is executing. The flush will continue to parse buffers as quickly
        /// as possible until the internal buffer queue is empty. Unless the user stops queueing data to be parsed (i.e. calling the
        /// <see cref="Write"/> method), the flush call may never return (not a happy situtation on shutdown).
        /// </para>
        /// <para>
        /// The <see cref="FrameParserBase{TFrameIdentifier}"/> does not clear queue prior to destruction. If the user fails to call
        /// this method before the class is destructed, there may be data that remains unparsed in the internal buffer.
        /// </para>
        /// </remarks>
        public override void Flush()
        {
            if (m_bufferQueue != null)
                m_bufferQueue.Flush();
        }

        /// <summary>
        /// Raises the <see cref="ReceivedConfigurationFrame"/> event.
        /// </summary>
        /// <param name="frame"><see cref="IConfigurationFrame"/> to send to <see cref="ReceivedConfigurationFrame"/> event.</param>
        protected virtual void OnReceivedConfigurationFrame(IConfigurationFrame frame)
        {
            if (ReceivedConfigurationFrame != null)
                ReceivedConfigurationFrame(this, new EventArgs<IConfigurationFrame>(frame));
        }

        /// <summary>
        /// Raises the <see cref="ReceivedDataFrame"/> event.
        /// </summary>
        /// <param name="frame"><see cref="IDataFrame"/> to send to <see cref="ReceivedDataFrame"/> event.</param>
        protected virtual void OnReceivedDataFrame(IDataFrame frame)
        {
            if (ReceivedDataFrame != null)
                ReceivedDataFrame(this, new EventArgs<IDataFrame>(frame));
        }

        /// <summary>
        /// Raises the <see cref="ReceivedHeaderFrame"/> event.
        /// </summary>
        /// <param name="frame"><see cref="IHeaderFrame"/> to send to <see cref="ReceivedHeaderFrame"/> event.</param>
        protected virtual void OnReceivedHeaderFrame(IHeaderFrame frame)
        {
            if (ReceivedHeaderFrame != null)
                ReceivedHeaderFrame(this, new EventArgs<IHeaderFrame>(frame));
        }

        /// <summary>
        /// Raises the <see cref="ReceivedCommandFrame"/> event.
        /// </summary>
        /// <param name="frame"><see cref="ICommandFrame"/> to send to <see cref="ReceivedCommandFrame"/> event.</param>
        protected virtual void OnReceivedCommandFrame(ICommandFrame frame)
        {
            if (ReceivedCommandFrame != null)
                ReceivedCommandFrame(this, new EventArgs<ICommandFrame>(frame));
        }

        /// <summary>
        /// Raises the <see cref="ReceivedUndeterminedFrame"/> event.
        /// </summary>
        /// <param name="frame"><see cref="IChannelFrame"/> to send to <see cref="ReceivedUndeterminedFrame"/> event.</param>
        protected virtual void OnReceivedUndeterminedFrame(IChannelFrame frame)
        {
            if (ReceivedUndeterminedFrame != null)
                ReceivedUndeterminedFrame(this, new EventArgs<IChannelFrame>(frame));
        }

        /// <summary>
        /// Raises the <see cref="ReceivedFrameBufferImage"/> event.
        /// </summary>
        /// <param name="frameType"><see cref="FundamentalFrameType"/> to send to <see cref="ReceivedFrameBufferImage"/> event.</param>
        /// <param name="binaryImage">Frame buffer image to send to <see cref="ReceivedFrameBufferImage"/> event.</param>
        /// <param name="offset">Offset into frame buffer image to send to <see cref="ReceivedFrameBufferImage"/> event.</param>
        /// <param name="length">Length of data in frame buffer image to send to <see cref="ReceivedFrameBufferImage"/> event.</param>
        protected virtual void OnReceivedFrameBufferImage(FundamentalFrameType frameType, byte[] binaryImage, int offset, int length)
        {
            if (ReceivedFrameBufferImage != null)
                ReceivedFrameBufferImage(this, new EventArgs<FundamentalFrameType, byte[], int, int>(frameType, binaryImage, offset, length));
        }

        /// <summary>
        /// Raises the <see cref="ConfigurationChanged"/> event.
        /// </summary>
        protected virtual void OnConfigurationChanged()
        {
            if (ConfigurationChanged != null)
                ConfigurationChanged(this, EventArgs.Empty);
        }

        /// <summary>
        /// Casts the parsed <see cref="IChannelFrame"/> to its specific implementation (i.e., <see cref="IDataFrame"/>, <see cref="IConfigurationFrame"/>, <see cref="ICommandFrame"/> or <see cref="IHeaderFrame"/>).
        /// </summary>
        /// <param name="frame"><see cref="IChannelFrame"/> that was parsed by <see cref="FrameImageParserBase{TTypeIdentifier,TOutputType}"/> that implements protocol specific common frame header interface.</param>
        protected virtual void OnReceivedChannelFrame(IChannelFrame frame)
        {
            if (frame != null)
            {
                IDataFrame dataFrame = frame as IDataFrame;

                if (dataFrame != null)
                {
                    // Frame was a data frame
                    OnReceivedDataFrame(dataFrame);
                }
                else
                {
                    IConfigurationFrame configFrame = frame as IConfigurationFrame;

                    if (configFrame != null)
                    {
                        // Frame was a configuration frame
                        OnReceivedConfigurationFrame(configFrame);
                    }
                    else
                    {
                        IHeaderFrame headerFrame = frame as IHeaderFrame;

                        if (headerFrame != null)
                        {
                            // Frame was a header frame
                            OnReceivedHeaderFrame(headerFrame);
                        }
                        else
                        {
                            ICommandFrame commandFrame = frame as ICommandFrame;

                            if (commandFrame != null)
                            {
                                // Frame was a command frame
                                OnReceivedCommandFrame(commandFrame);
                            }
                            else
                            {
                                // Frame type was undetermined
                                OnReceivedUndeterminedFrame(frame);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Creates the internal buffer queue.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method is virtual to allow derived classes to customize the style of processing queue used when consumers
        /// choose to implement an internal buffer queue (i.e., set <see cref="ExecuteParseOnSeparateThread"/> to true).
        /// Default type is a real-time queue with the default settings. When overriding this method, be sure to use the
        /// <see cref="ParseQueuedBuffers"/> method for the <see cref="ProcessQueue{T}"/>) item processing delegate.
        /// </para>
        /// <para>
        /// Note that current design only supports synchronous parsing - consumer overriding this method to return
        /// an asynchronous (i.e., multi-threaded) process queue will need to redesign the processing delegate.
        /// </para>
        /// </remarks>
        /// <returns>New internal buffer processing queue (i.e., a new <see cref="ProcessQueue{T}"/>).</returns>
        protected virtual ProcessQueue<byte[]> CreateBufferQueue()
        {
            return ProcessQueue<byte[]>.CreateRealTimeQueue(ParseQueuedBuffers);
        }

        /// <summary>
        /// This method is used by the internal <see cref="ProcessQueue{T}"/> to process all queued data buffers.
        /// </summary>
        /// <param name="buffers">Queued buffers to process.</param>
        /// <remarks>
        /// This is the item processing delegate to use when overriding the <see cref="CreateBufferQueue"/> method.
        /// </remarks>
        protected void ParseQueuedBuffers(byte[][] buffers)
        {
            // Parse combined data buffers
            byte[] combinedBuffers = buffers.Combine();
            base.Write(combinedBuffers, 0, combinedBuffers.Length);
        }

        // Handles reception of data from base class event "DataParsed"
        private void base_DataParsed(object sender, EventArgs<ISupportFrameImage<TFrameIdentifier>> e)
        {
            // Call overridable channel frame function handler...
            OnReceivedChannelFrame(e.Argument as IChannelFrame);
        }

        // Handles any exceptions encountered in the buffer queue
        private void m_bufferQueue_ProcessException(object sender, EventArgs<Exception> e)
        {
            OnParsingException(e.Argument);
        }

        #endregion
    }
}