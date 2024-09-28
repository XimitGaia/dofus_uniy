using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag;

[Token(Token = "0x2000445")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HavenBagPermissionsUpdateEvent : IMessage<HavenBagPermissionsUpdateEvent>, IMessage, IEquatable<HavenBagPermissionsUpdateEvent>, IDeepCloneable<HavenBagPermissionsUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x4000EBE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HavenBagPermissionsUpdateEvent> _parser;

	[Token(Token = "0x4000EBF")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000EC0")]
	public const int PermissionsFieldNumber = 1;

	[Token(Token = "0x4000EC1")]
	[FieldOffset(Offset = "0x18")]
	private int permissions_;

	[Token(Token = "0x1700099B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<HavenBagPermissionsUpdateEvent> Parser
	{
		[Token(Token = "0x6002CF3")]
		[Address(RVA = "0x9BFE90", Offset = "0x9BF290", VA = "0x1809BFE90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700099C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002CF4")]
		[Address(RVA = "0x9BFDE0", Offset = "0x9BF1E0", VA = "0x1809BFDE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700099D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002CF5")]
		[Address(RVA = "0x9BFEE0", Offset = "0x9BF2E0", VA = "0x1809BFEE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700099E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Permissions
	{
		[Token(Token = "0x6002CF9")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002CFA")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6002CF6")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagPermissionsUpdateEvent()
	{
	}

	[Token(Token = "0x6002CF7")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagPermissionsUpdateEvent(HavenBagPermissionsUpdateEvent other)
	{
	}

	[Token(Token = "0x6002CF8")]
	[Address(RVA = "0x9BFB70", Offset = "0x9BEF70", VA = "0x1809BFB70", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagPermissionsUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002CFB")]
	[Address(RVA = "0x9BFBF0", Offset = "0x9BEFF0", VA = "0x1809BFBF0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002CFC")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HavenBagPermissionsUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002CFD")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002CFE")]
	[Address(RVA = "0x9BFC80", Offset = "0x9BF080", VA = "0x1809BFC80", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002CFF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002D00")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002D01")]
	[Address(RVA = "0x9BFAE0", Offset = "0x9BEEE0", VA = "0x1809BFAE0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002D02")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HavenBagPermissionsUpdateEvent other)
	{
	}

	[Token(Token = "0x6002D03")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002D04")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
