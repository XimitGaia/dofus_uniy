using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000B0F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorStaticInformation : IMessage<TaxCollectorStaticInformation>, IMessage, IEquatable<TaxCollectorStaticInformation>, IDeepCloneable<TaxCollectorStaticInformation>, IBufferMessage
{
	[Token(Token = "0x400290B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorStaticInformation> _parser;

	[Token(Token = "0x400290C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400290D")]
	public const int UidFieldNumber = 1;

	[Token(Token = "0x400290E")]
	[FieldOffset(Offset = "0x18")]
	private string uid_;

	[Token(Token = "0x400290F")]
	public const int FirstNameIdFieldNumber = 2;

	[Token(Token = "0x4002910")]
	[FieldOffset(Offset = "0x20")]
	private int firstNameId_;

	[Token(Token = "0x4002911")]
	public const int LastNameIdFieldNumber = 3;

	[Token(Token = "0x4002912")]
	[FieldOffset(Offset = "0x24")]
	private int lastNameId_;

	[Token(Token = "0x4002913")]
	public const int AllianceFieldNumber = 4;

	[Token(Token = "0x4002914")]
	[FieldOffset(Offset = "0x28")]
	private AllianceInformation alliance_;

	[Token(Token = "0x4002915")]
	public const int CallerIdFieldNumber = 5;

	[Token(Token = "0x4002916")]
	[FieldOffset(Offset = "0x30")]
	private long callerId_;

	[Token(Token = "0x1700198A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TaxCollectorStaticInformation> Parser
	{
		[Token(Token = "0x600744B")]
		[Address(RVA = "0xC12B40", Offset = "0xC11F40", VA = "0x180C12B40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700198B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600744C")]
		[Address(RVA = "0xC12A90", Offset = "0xC11E90", VA = "0x180C12A90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700198C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600744D")]
		[Address(RVA = "0xC12E20", Offset = "0xC12220", VA = "0x180C12E20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700198D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Uid
	{
		[Token(Token = "0x6007451")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007452")]
		[Address(RVA = "0xC12F00", Offset = "0xC12300", VA = "0x180C12F00")]
		set
		{
		}
	}

	[Token(Token = "0x1700198E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FirstNameId
	{
		[Token(Token = "0x6007453")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007454")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x1700198F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LastNameId
	{
		[Token(Token = "0x6007455")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007456")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x17001990")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceInformation Alliance
	{
		[Token(Token = "0x6007457")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007458")]
		[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
		set
		{
		}
	}

	[Token(Token = "0x17001991")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long CallerId
	{
		[Token(Token = "0x6007459")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600745A")]
		[Address(RVA = "0x952BB0", Offset = "0x951FB0", VA = "0x180952BB0")]
		set
		{
		}
	}

	[Token(Token = "0x600744E")]
	[Address(RVA = "0xC12A40", Offset = "0xC11E40", VA = "0x180C12A40")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorStaticInformation()
	{
	}

	[Token(Token = "0x600744F")]
	[Address(RVA = "0xC12960", Offset = "0xC11D60", VA = "0x180C12960")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorStaticInformation(TaxCollectorStaticInformation other)
	{
	}

	[Token(Token = "0x6007450")]
	[Address(RVA = "0xC12390", Offset = "0xC11790", VA = "0x180C12390", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorStaticInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x600745B")]
	[Address(RVA = "0xC12520", Offset = "0xC11920", VA = "0x180C12520", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600745C")]
	[Address(RVA = "0xC12490", Offset = "0xC11890", VA = "0x180C12490", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TaxCollectorStaticInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x600745D")]
	[Address(RVA = "0xC12600", Offset = "0xC11A00", VA = "0x180C12600", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600745E")]
	[Address(RVA = "0xC12800", Offset = "0xC11C00", VA = "0x180C12800", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600745F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007460")]
	[Address(RVA = "0xC12D30", Offset = "0xC12130", VA = "0x180C12D30", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007461")]
	[Address(RVA = "0xC12250", Offset = "0xC11650", VA = "0x180C12250", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007462")]
	[Address(RVA = "0xC126F0", Offset = "0xC11AF0", VA = "0x180C126F0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TaxCollectorStaticInformation other)
	{
	}

	[Token(Token = "0x6007463")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007464")]
	[Address(RVA = "0xC12B90", Offset = "0xC11F90", VA = "0x180C12B90", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
