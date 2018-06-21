using System;
using System.Collections.Generic;
using Medidata.RWS.NET.Standard.ODM;

namespace Medidata.RWS.NET.Standard.Builders
{
    /// <summary>
    /// A builder for constructing "SubjectData" objects in a state suitable for transmission.
    /// </summary>
    /// <tocexclude />
    public class SubjectDataBuilder : AuditableBuilderBase<SubjectData, SubjectDataBuilder>, SpecifiesTransactionType<SubjectDataBuilder>
    {

        /// <summary>
        /// Initializes a new instance of the SubjectDataBuilder class using the specified SubjectKey and LocationOID values.
        /// </summary>
        /// <param name="subjectKey"></param>
        /// <param name="locationOID"></param>
        public SubjectDataBuilder(string subjectKey, string locationOID)
        {

            thisNode = new SubjectData
            {
                SubjectKey = subjectKey,
                StudyEventData = new List<StudyEventData>(),
                AuditRecord = null,
                Signature = null,
                InvestigatorRef = null,
                SiteRef = new SiteRef
                {
                    LocationOID = locationOID
                },
                TransactionType = TransactionType.Update //default transaction type

            };
        }

        /// <summary>
        /// Add a "StudyEventData" node and set the "StudyEventOID" and "StudyEventRepeatKey" attributes.
        /// </summary>
        /// <param name="StudyEventOID"></param>
        /// <param name="StudyEventRepeatKey"></param>
        /// <param name="studyEventDataBuilder"></param>
        /// <returns></returns>
        public SubjectDataBuilder AddStudyEventData(string StudyEventOID, int StudyEventRepeatKey, Action<StudyEventDataBuilder> studyEventDataBuilder)
        {

            return AddStudyEventData(StudyEventOID, StudyEventRepeatKey.ToString(), studyEventDataBuilder);

        }

        /// <summary>
        /// Add a "StudyEventData" node and set the "StudyEventOID" and "StudyEventRepeatKey" attributes.
        /// </summary>
        /// <param name="StudyEventOID"></param>
        /// <param name="StudyEventRepeatKey"></param>
        /// <param name="studyEventDataBuilder"></param>
        /// <returns></returns>
        public SubjectDataBuilder AddStudyEventData(string StudyEventOID, string StudyEventRepeatKey, Action<StudyEventDataBuilder> studyEventDataBuilder)
        {

            var sedb = new StudyEventDataBuilder(StudyEventOID, StudyEventRepeatKey);

            studyEventDataBuilder(sedb);

            thisNode.StudyEventData.Add(sedb.Build());

            return this;

        }


        /// <summary>
        /// Add a "StudyEventData" node and set the "StudyEventOID" attribute.
        /// </summary>
        /// <param name="StudyEventOID"></param>
        /// <param name="StudyEventRepeatKey"></param>
        /// <param name="studyEventDataBuilder"></param>
        /// <returns></returns>
        public SubjectDataBuilder AddStudyEventData(string StudyEventOID, Action<StudyEventDataBuilder> studyEventDataBuilder)
        {

            var sedb = new StudyEventDataBuilder(StudyEventOID);

            studyEventDataBuilder(sedb);

            thisNode.StudyEventData.Add(sedb.Build());

            return this;

        }

        /// <summary>
        /// Set the transaction type on the "SubjectData" node.
        /// </summary>
        /// <param name="tranxType"></param>
        /// <returns></returns>
        public SubjectDataBuilder WithTransactionType(TransactionType tranxType)
        {

            thisNode.TransactionType = tranxType;
            return this;

        }

        /// <summary>
        /// Return current instance
        /// </summary>
        /// <returns></returns>
        protected override SubjectDataBuilder ThisAsTSelf()
        {
            return this;
        }
    }
}