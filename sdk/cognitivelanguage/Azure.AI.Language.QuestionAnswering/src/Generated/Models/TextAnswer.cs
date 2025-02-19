// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.Language.QuestionAnswering
{
    /// <summary> Represents answer result. </summary>
    public partial class TextAnswer
    {
        /// <summary> Initializes a new instance of TextAnswer. </summary>
        internal TextAnswer()
        {
        }

        /// <summary> Initializes a new instance of TextAnswer. </summary>
        /// <param name="answer"> Answer. </param>
        /// <param name="confidence"> answer confidence score, value ranges from 0 to 1. </param>
        /// <param name="id"> record ID. </param>
        /// <param name="shortAnswer"> Answer span object with respect to user's question. </param>
        /// <param name="offset"> The sentence offset from the start of the document. </param>
        /// <param name="length"> The length of the sentence. </param>
        internal TextAnswer(string answer, double? confidence, string id, AnswerSpan shortAnswer, int? offset, int? length)
        {
            Answer = answer;
            Confidence = confidence;
            Id = id;
            ShortAnswer = shortAnswer;
            Offset = offset;
            Length = length;
        }

        /// <summary> Answer. </summary>
        public string Answer { get; }
        /// <summary> answer confidence score, value ranges from 0 to 1. </summary>
        public double? Confidence { get; }
        /// <summary> record ID. </summary>
        public string Id { get; }
        /// <summary> Answer span object with respect to user's question. </summary>
        public AnswerSpan ShortAnswer { get; }
        /// <summary> The sentence offset from the start of the document. </summary>
        public int? Offset { get; }
        /// <summary> The length of the sentence. </summary>
        public int? Length { get; }
    }
}
