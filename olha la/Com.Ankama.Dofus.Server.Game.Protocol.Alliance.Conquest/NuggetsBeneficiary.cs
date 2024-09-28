using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest;

[Token(Token = "0x2000CF9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class NuggetsBeneficiary : IMessage<NuggetsBeneficiary>, IMessage, IEquatable<NuggetsBeneficiary>, IDeepCloneable<NuggetsBeneficiary>, IBufferMessage
{
	[Token(Token = "0x4002FBA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<NuggetsBeneficiary> _parser;

	[Token(Token = "0x4002FBB")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002FBC")]
	public const int CharacterIdFieldNumber = 1;

	[Token(Token = "0x4002FBD")]
	[FieldOffset(Offset = "0x18")]
	private long characterId_;

	[Token(Token = "0x4002FBE")]
	public const int NuggetsQuantityFieldNumber = 2;

	[Token(Token = "0x4002FBF")]
	[FieldOffset(Offset = "0x20")]
	private int nuggetsQuantity_;

	[Token(Token = "0x17001DE0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<NuggetsBeneficiary> Parser
	{
		[Token(Token = "0x60088AE")]
		[Address(RVA = "0xCB4B50", Offset = "0xCB3F50", VA = "0x180CB4B50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DE1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60088AF")]
		[Address(RVA = "0xCB4AA0", Offset = "0xCB3EA0", VA = "0x180CB4AA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DE2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60088B0")]
		[Address(RVA = "0xCB4BA0", Offset = "0xCB3FA0", VA = "0x180CB4BA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DE3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long CharacterId
	{
		[Token(Token = "0x60088B4")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60088B5")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17001DE4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int NuggetsQuantity
	{
		[Token(Token = "0x60088B6")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60088B7")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x60088B1")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NuggetsBeneficiary()
	{
	}

	[Token(Token = "0x60088B2")]
	[Address(RVA = "0x948CF0", Offset = "0x9480F0", VA = "0x180948CF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NuggetsBeneficiary(NuggetsBeneficiary other)
	{
	}

	[Token(Token = "0x60088B3")]
	[Address(RVA = "0xCB4810", Offset = "0xCB3C10", VA = "0x180CB4810", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NuggetsBeneficiary Clone()
	{
		return null;
	}

	[Token(Token = "0x60088B8")]
	[Address(RVA = "0xCB48A0", Offset = "0xCB3CA0", VA = "0x180CB48A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60088B9")]
	[Address(RVA = "0x9489C0", Offset = "0x947DC0", VA = "0x1809489C0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NuggetsBeneficiary other)
	{
		return default(bool);
	}

	[Token(Token = "0x60088BA")]
	[Address(RVA = "0x948AA0", Offset = "0x947EA0", VA = "0x180948AA0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60088BB")]
	[Address(RVA = "0xCB4940", Offset = "0xCB3D40", VA = "0x180CB4940", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60088BC")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60088BD")]
	[Address(RVA = "0x9E9520", Offset = "0x9E8920", VA = "0x1809E9520", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60088BE")]
	[Address(RVA = "0xCB4750", Offset = "0xCB3B50", VA = "0x180CB4750", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60088BF")]
	[Address(RVA = "0x948B30", Offset = "0x947F30", VA = "0x180948B30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NuggetsBeneficiary other)
	{
	}

	[Token(Token = "0x60088C0")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60088C1")]
	[Address(RVA = "0x948E20", Offset = "0x948220", VA = "0x180948E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
