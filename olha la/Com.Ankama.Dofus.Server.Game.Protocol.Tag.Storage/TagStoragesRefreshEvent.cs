using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tag.Storage;

[Token(Token = "0x20000DF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TagStoragesRefreshEvent : IMessage<TagStoragesRefreshEvent>, IMessage, IEquatable<TagStoragesRefreshEvent>, IDeepCloneable<TagStoragesRefreshEvent>, IBufferMessage
{
	[Token(Token = "0x40002F6")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TagStoragesRefreshEvent> _parser;

	[Token(Token = "0x40002F7")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40002F8")]
	public const int TagInformationFieldNumber = 1;

	[Token(Token = "0x40002F9")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<TagInformation> _repeated_tagInformation_codec;

	[Token(Token = "0x40002FA")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<TagInformation> tagInformation_;

	[Token(Token = "0x170001D2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TagStoragesRefreshEvent> Parser
	{
		[Token(Token = "0x600089B")]
		[Address(RVA = "0xA62550", Offset = "0xA61950", VA = "0x180A62550")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001D3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600089C")]
		[Address(RVA = "0xA624A0", Offset = "0xA618A0", VA = "0x180A624A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001D4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600089D")]
		[Address(RVA = "0xA62760", Offset = "0xA61B60", VA = "0x180A62760", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001D5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<TagInformation> TagInformation
	{
		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600089E")]
	[Address(RVA = "0xA62390", Offset = "0xA61790", VA = "0x180A62390")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TagStoragesRefreshEvent()
	{
	}

	[Token(Token = "0x600089F")]
	[Address(RVA = "0xA62410", Offset = "0xA61810", VA = "0x180A62410")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TagStoragesRefreshEvent(TagStoragesRefreshEvent other)
	{
	}

	[Token(Token = "0x60008A0")]
	[Address(RVA = "0xA61EE0", Offset = "0xA612E0", VA = "0x180A61EE0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TagStoragesRefreshEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60008A2")]
	[Address(RVA = "0xA61FA0", Offset = "0xA613A0", VA = "0x180A61FA0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60008A3")]
	[Address(RVA = "0xA62080", Offset = "0xA61480", VA = "0x180A62080", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TagStoragesRefreshEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60008A4")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60008A5")]
	[Address(RVA = "0xA62190", Offset = "0xA61590", VA = "0x180A62190", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60008A6")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60008A7")]
	[Address(RVA = "0xA626B0", Offset = "0xA61AB0", VA = "0x180A626B0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60008A8")]
	[Address(RVA = "0xA61E40", Offset = "0xA61240", VA = "0x180A61E40", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60008A9")]
	[Address(RVA = "0xA62110", Offset = "0xA61510", VA = "0x180A62110", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TagStoragesRefreshEvent other)
	{
	}

	[Token(Token = "0x60008AA")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60008AB")]
	[Address(RVA = "0xA625A0", Offset = "0xA619A0", VA = "0x180A625A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
