using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount;

[Token(Token = "0x200032D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MountEmoteIconUsedEvent : IMessage<MountEmoteIconUsedEvent>, IMessage, IEquatable<MountEmoteIconUsedEvent>, IDeepCloneable<MountEmoteIconUsedEvent>, IBufferMessage
{
	[Token(Token = "0x4000AF8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MountEmoteIconUsedEvent> _parser;

	[Token(Token = "0x4000AF9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000AFA")]
	public const int MountIdFieldNumber = 1;

	[Token(Token = "0x4000AFB")]
	[FieldOffset(Offset = "0x18")]
	private int mountId_;

	[Token(Token = "0x4000AFC")]
	public const int ReactionFieldNumber = 2;

	[Token(Token = "0x4000AFD")]
	[FieldOffset(Offset = "0x1C")]
	private int reaction_;

	[Token(Token = "0x17000708")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MountEmoteIconUsedEvent> Parser
	{
		[Token(Token = "0x60020D5")]
		[Address(RVA = "0x97B3C0", Offset = "0x97A7C0", VA = "0x18097B3C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000709")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60020D6")]
		[Address(RVA = "0x97B310", Offset = "0x97A710", VA = "0x18097B310")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700070A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60020D7")]
		[Address(RVA = "0x97B410", Offset = "0x97A810", VA = "0x18097B410", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700070B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MountId
	{
		[Token(Token = "0x60020DB")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60020DC")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700070C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Reaction
	{
		[Token(Token = "0x60020DD")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60020DE")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x60020D8")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountEmoteIconUsedEvent()
	{
	}

	[Token(Token = "0x60020D9")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountEmoteIconUsedEvent(MountEmoteIconUsedEvent other)
	{
	}

	[Token(Token = "0x60020DA")]
	[Address(RVA = "0x97B090", Offset = "0x97A490", VA = "0x18097B090", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountEmoteIconUsedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60020DF")]
	[Address(RVA = "0x97B120", Offset = "0x97A520", VA = "0x18097B120", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60020E0")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MountEmoteIconUsedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60020E1")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60020E2")]
	[Address(RVA = "0x97B1B0", Offset = "0x97A5B0", VA = "0x18097B1B0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60020E3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60020E4")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60020E5")]
	[Address(RVA = "0x97AFD0", Offset = "0x97A3D0", VA = "0x18097AFD0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60020E6")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MountEmoteIconUsedEvent other)
	{
	}

	[Token(Token = "0x60020E7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60020E8")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
