using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management;

[Token(Token = "0x2000896")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterSelectionWithRemodelRequest : IMessage<CharacterSelectionWithRemodelRequest>, IMessage, IEquatable<CharacterSelectionWithRemodelRequest>, IDeepCloneable<CharacterSelectionWithRemodelRequest>, IBufferMessage
{
	[Token(Token = "0x4001DAB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterSelectionWithRemodelRequest> _parser;

	[Token(Token = "0x4001DAC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001DAD")]
	public const int CharacterIdFieldNumber = 1;

	[Token(Token = "0x4001DAE")]
	[FieldOffset(Offset = "0x18")]
	private long characterId_;

	[Token(Token = "0x4001DAF")]
	public const int RemodelingInformationFieldNumber = 2;

	[Token(Token = "0x4001DB0")]
	[FieldOffset(Offset = "0x20")]
	private Com.Ankama.Dofus.Server.Game.Protocol.Common.Character remodelingInformation_;

	[Token(Token = "0x17001360")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharacterSelectionWithRemodelRequest> Parser
	{
		[Token(Token = "0x6005B1C")]
		[Address(RVA = "0xB26200", Offset = "0xB25600", VA = "0x180B26200")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001361")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005B1D")]
		[Address(RVA = "0xB26150", Offset = "0xB25550", VA = "0x180B26150")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001362")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005B1E")]
		[Address(RVA = "0xB26370", Offset = "0xB25770", VA = "0x180B26370", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001363")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long CharacterId
	{
		[Token(Token = "0x6005B22")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6005B23")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17001364")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Com.Ankama.Dofus.Server.Game.Protocol.Common.Character RemodelingInformation
	{
		[Token(Token = "0x6005B24")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005B25")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x6005B1F")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterSelectionWithRemodelRequest()
	{
	}

	[Token(Token = "0x6005B20")]
	[Address(RVA = "0xB23950", Offset = "0xB22D50", VA = "0x180B23950")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterSelectionWithRemodelRequest(CharacterSelectionWithRemodelRequest other)
	{
	}

	[Token(Token = "0x6005B21")]
	[Address(RVA = "0xB25DB0", Offset = "0xB251B0", VA = "0x180B25DB0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterSelectionWithRemodelRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005B26")]
	[Address(RVA = "0xB25E50", Offset = "0xB25250", VA = "0x180B25E50", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005B27")]
	[Address(RVA = "0x953270", Offset = "0x952670", VA = "0x180953270", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharacterSelectionWithRemodelRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005B28")]
	[Address(RVA = "0x9533A0", Offset = "0x9527A0", VA = "0x1809533A0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005B29")]
	[Address(RVA = "0xB25FF0", Offset = "0xB253F0", VA = "0x180B25FF0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005B2A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005B2B")]
	[Address(RVA = "0x953910", Offset = "0x952D10", VA = "0x180953910", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005B2C")]
	[Address(RVA = "0xB25CF0", Offset = "0xB250F0", VA = "0x180B25CF0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005B2D")]
	[Address(RVA = "0xB25F10", Offset = "0xB25310", VA = "0x180B25F10", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterSelectionWithRemodelRequest other)
	{
	}

	[Token(Token = "0x6005B2E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005B2F")]
	[Address(RVA = "0xB26250", Offset = "0xB25650", VA = "0x180B26250", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
