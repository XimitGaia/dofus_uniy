using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount;

[Token(Token = "0x2000327")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MountEquippedErrorEvent : IMessage<MountEquippedErrorEvent>, IMessage, IEquatable<MountEquippedErrorEvent>, IDeepCloneable<MountEquippedErrorEvent>, IBufferMessage
{
	[Token(Token = "0x2000328")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000329")]
		public enum MountEquippedError
		{
			[Token(Token = "0x4000AEF")]
			[OriginalName("UNEQUIPPED")]
			Unequipped,
			[Token(Token = "0x4000AF0")]
			[OriginalName("EQUIPPED")]
			Equipped,
			[Token(Token = "0x4000AF1")]
			[OriginalName("RIDING")]
			Riding
		}
	}

	[Token(Token = "0x4000AEA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MountEquippedErrorEvent> _parser;

	[Token(Token = "0x4000AEB")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000AEC")]
	public const int ErrorFieldNumber = 1;

	[Token(Token = "0x4000AED")]
	[FieldOffset(Offset = "0x18")]
	private Types.MountEquippedError error_;

	[Token(Token = "0x17000700")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MountEquippedErrorEvent> Parser
	{
		[Token(Token = "0x60020A9")]
		[Address(RVA = "0x97B8A0", Offset = "0x97ACA0", VA = "0x18097B8A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000701")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60020AA")]
		[Address(RVA = "0x97B7F0", Offset = "0x97ABF0", VA = "0x18097B7F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000702")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60020AB")]
		[Address(RVA = "0x97B8F0", Offset = "0x97ACF0", VA = "0x18097B8F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000703")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.MountEquippedError Error
	{
		[Token(Token = "0x60020AF")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.MountEquippedError);
		}
		[Token(Token = "0x60020B0")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60020AC")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountEquippedErrorEvent()
	{
	}

	[Token(Token = "0x60020AD")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountEquippedErrorEvent(MountEquippedErrorEvent other)
	{
	}

	[Token(Token = "0x60020AE")]
	[Address(RVA = "0x97B580", Offset = "0x97A980", VA = "0x18097B580", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountEquippedErrorEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60020B1")]
	[Address(RVA = "0x97B600", Offset = "0x97AA00", VA = "0x18097B600", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60020B2")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MountEquippedErrorEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60020B3")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60020B4")]
	[Address(RVA = "0x97B690", Offset = "0x97AA90", VA = "0x18097B690", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60020B5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60020B6")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60020B7")]
	[Address(RVA = "0x97B4F0", Offset = "0x97A8F0", VA = "0x18097B4F0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60020B8")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MountEquippedErrorEvent other)
	{
	}

	[Token(Token = "0x60020B9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60020BA")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
