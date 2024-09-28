using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag;

[Token(Token = "0x200042D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HavenBagPermissionsUpdateRequest : IMessage<HavenBagPermissionsUpdateRequest>, IMessage, IEquatable<HavenBagPermissionsUpdateRequest>, IDeepCloneable<HavenBagPermissionsUpdateRequest>, IBufferMessage
{
	[Token(Token = "0x4000E7E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HavenBagPermissionsUpdateRequest> _parser;

	[Token(Token = "0x4000E7F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000E80")]
	public const int PermissionsFieldNumber = 1;

	[Token(Token = "0x4000E81")]
	[FieldOffset(Offset = "0x18")]
	private int permissions_;

	[Token(Token = "0x17000971")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<HavenBagPermissionsUpdateRequest> Parser
	{
		[Token(Token = "0x6002C16")]
		[Address(RVA = "0x9C0370", Offset = "0x9BF770", VA = "0x1809C0370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000972")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002C17")]
		[Address(RVA = "0x9C02C0", Offset = "0x9BF6C0", VA = "0x1809C02C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000973")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002C18")]
		[Address(RVA = "0x9C03C0", Offset = "0x9BF7C0", VA = "0x1809C03C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000974")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Permissions
	{
		[Token(Token = "0x6002C1C")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002C1D")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6002C19")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagPermissionsUpdateRequest()
	{
	}

	[Token(Token = "0x6002C1A")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagPermissionsUpdateRequest(HavenBagPermissionsUpdateRequest other)
	{
	}

	[Token(Token = "0x6002C1B")]
	[Address(RVA = "0x9C0050", Offset = "0x9BF450", VA = "0x1809C0050", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagPermissionsUpdateRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002C1E")]
	[Address(RVA = "0x9C00D0", Offset = "0x9BF4D0", VA = "0x1809C00D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002C1F")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(HavenBagPermissionsUpdateRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002C20")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002C21")]
	[Address(RVA = "0x9C0160", Offset = "0x9BF560", VA = "0x1809C0160", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002C22")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002C23")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002C24")]
	[Address(RVA = "0x9BFFC0", Offset = "0x9BF3C0", VA = "0x1809BFFC0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002C25")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HavenBagPermissionsUpdateRequest other)
	{
	}

	[Token(Token = "0x6002C26")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002C27")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
