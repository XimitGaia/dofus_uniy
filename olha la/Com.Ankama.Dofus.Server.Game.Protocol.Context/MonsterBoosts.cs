using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context;

[Token(Token = "0x200079B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonsterBoosts : IMessage<MonsterBoosts>, IMessage, IEquatable<MonsterBoosts>, IDeepCloneable<MonsterBoosts>, IBufferMessage
{
	[Token(Token = "0x4001A75")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MonsterBoosts> _parser;

	[Token(Token = "0x4001A76")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001A77")]
	public const int IdFieldNumber = 1;

	[Token(Token = "0x4001A78")]
	[FieldOffset(Offset = "0x18")]
	private int id_;

	[Token(Token = "0x4001A79")]
	public const int XpBoostFieldNumber = 2;

	[Token(Token = "0x4001A7A")]
	[FieldOffset(Offset = "0x1C")]
	private int xpBoost_;

	[Token(Token = "0x4001A7B")]
	public const int DropBoostFieldNumber = 3;

	[Token(Token = "0x4001A7C")]
	[FieldOffset(Offset = "0x20")]
	private int dropBoost_;

	[Token(Token = "0x17001146")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonsterBoosts> Parser
	{
		[Token(Token = "0x60050EE")]
		[Address(RVA = "0xADF930", Offset = "0xADED30", VA = "0x180ADF930")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001147")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60050EF")]
		[Address(RVA = "0xADF880", Offset = "0xADEC80", VA = "0x180ADF880")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001148")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60050F0")]
		[Address(RVA = "0xADF980", Offset = "0xADED80", VA = "0x180ADF980", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001149")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Id
	{
		[Token(Token = "0x60050F4")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60050F5")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700114A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int XpBoost
	{
		[Token(Token = "0x60050F6")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60050F7")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x1700114B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DropBoost
	{
		[Token(Token = "0x60050F8")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60050F9")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x60050F1")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MonsterBoosts()
	{
	}

	[Token(Token = "0x60050F2")]
	[Address(RVA = "0x939530", Offset = "0x938930", VA = "0x180939530")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterBoosts(MonsterBoosts other)
	{
	}

	[Token(Token = "0x60050F3")]
	[Address(RVA = "0xADF5F0", Offset = "0xADE9F0", VA = "0x180ADF5F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterBoosts Clone()
	{
		return null;
	}

	[Token(Token = "0x60050FA")]
	[Address(RVA = "0xADF680", Offset = "0xADEA80", VA = "0x180ADF680", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60050FB")]
	[Address(RVA = "0x947820", Offset = "0x946C20", VA = "0x180947820", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonsterBoosts other)
	{
		return default(bool);
	}

	[Token(Token = "0x60050FC")]
	[Address(RVA = "0x977E40", Offset = "0x977240", VA = "0x180977E40", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60050FD")]
	[Address(RVA = "0xADF720", Offset = "0xADEB20", VA = "0x180ADF720", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60050FE")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60050FF")]
	[Address(RVA = "0x978140", Offset = "0x977540", VA = "0x180978140", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005100")]
	[Address(RVA = "0xADF510", Offset = "0xADE910", VA = "0x180ADF510", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005101")]
	[Address(RVA = "0x947910", Offset = "0x946D10", VA = "0x180947910", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonsterBoosts other)
	{
	}

	[Token(Token = "0x6005102")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005103")]
	[Address(RVA = "0x947BE0", Offset = "0x946FE0", VA = "0x180947BE0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
