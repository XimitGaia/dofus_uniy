using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x20009EB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceMemberInformation : IMessage<AllianceMemberInformation>, IMessage, IEquatable<AllianceMemberInformation>, IDeepCloneable<AllianceMemberInformation>, IBufferMessage
{
	[Token(Token = "0x4002340")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceMemberInformation> _parser;

	[Token(Token = "0x4002341")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002342")]
	public const int InformationFieldNumber = 1;

	[Token(Token = "0x4002343")]
	[FieldOffset(Offset = "0x18")]
	private Character information_;

	[Token(Token = "0x4002344")]
	public const int AvaRoleIdFieldNumber = 2;

	[Token(Token = "0x4002345")]
	[FieldOffset(Offset = "0x20")]
	private int avaRoleId_;

	[Token(Token = "0x1700162D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceMemberInformation> Parser
	{
		[Token(Token = "0x6006758")]
		[Address(RVA = "0xBA2640", Offset = "0xBA1A40", VA = "0x180BA2640")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700162E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006759")]
		[Address(RVA = "0xBA2590", Offset = "0xBA1990", VA = "0x180BA2590")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700162F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600675A")]
		[Address(RVA = "0xBA27B0", Offset = "0xBA1BB0", VA = "0x180BA27B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001630")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Character Information
	{
		[Token(Token = "0x600675E")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600675F")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17001631")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AvaRoleId
	{
		[Token(Token = "0x6006760")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006761")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x600675B")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceMemberInformation()
	{
	}

	[Token(Token = "0x600675C")]
	[Address(RVA = "0xB513A0", Offset = "0xB507A0", VA = "0x180B513A0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceMemberInformation(AllianceMemberInformation other)
	{
	}

	[Token(Token = "0x600675D")]
	[Address(RVA = "0xBA2200", Offset = "0xBA1600", VA = "0x180BA2200", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceMemberInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x6006762")]
	[Address(RVA = "0xBA22B0", Offset = "0xBA16B0", VA = "0x180BA22B0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006763")]
	[Address(RVA = "0x98AC30", Offset = "0x98A030", VA = "0x18098AC30", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceMemberInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006764")]
	[Address(RVA = "0x98ACA0", Offset = "0x98A0A0", VA = "0x18098ACA0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006765")]
	[Address(RVA = "0xBA2430", Offset = "0xBA1830", VA = "0x180BA2430", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006766")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006767")]
	[Address(RVA = "0x9D2390", Offset = "0x9D1790", VA = "0x1809D2390", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006768")]
	[Address(RVA = "0xBA2140", Offset = "0xBA1540", VA = "0x180BA2140", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006769")]
	[Address(RVA = "0xBA2360", Offset = "0xBA1760", VA = "0x180BA2360", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceMemberInformation other)
	{
	}

	[Token(Token = "0x600676A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600676B")]
	[Address(RVA = "0xBA2690", Offset = "0xBA1A90", VA = "0x180BA2690", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
