// This code is part of the Fungus library (https://github.com/snozbot/fungus)
// It is released for free under the MIT open source license (https://github.com/snozbot/fungus/blob/master/LICENSE)

namespace Fungus
{

    /// <summary>
    /// For classes that encode and decode save data.
    /// TEncoded is the encoded form of the data, TDecoded is the decoded form of the data.
    /// </summary>
    public interface ISaveDataItemSerializer<TEncoded, TDecoded>
    {
        int Order { get; }
        string DataTypeKey { get; }

        /// <summary>
        /// Executes procedures that this serializer should do before doing any encoding.
        /// </summary>
        void PreDecode();

        /// <summary>
        /// Executes procedures that this serializer should do when decoding is done.
        /// </summary>
        void PostDecode();

        TEncoded Encode();

        TDecoded Decode(TEncoded encoded);
    }
}
