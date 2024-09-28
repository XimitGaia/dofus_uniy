using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tag.Storage;

[Token(Token = "0x20000DB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class UpdateTagStorageContentRequest : IMessage<UpdateTagStorageContentRequest>, IMessage, IEquatable<UpdateTagStorageContentRequest>, IDeepCloneable<UpdateTagStorageContentRequest>, IBufferMessage
{
	[Token(Token = "0x40002EC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<UpdateTagStorageContentRequest> _parser;

	[Token(Token = "0x40002ED")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40002EE")]
	public const int TagStorageDataFieldNumber = 1;

	[Token(Token = "0x40002EF")]
	[FieldOffset(Offset = "0x18")]
	private TagStorageData tagStorageData_;

	[Token(Token = "0x170001CA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UpdateTagStorageContentRequest> Parser
	{
		[Token(Token = "0x600086F")]
		[Address(RVA = "0xA6CE80", Offset = "0xA6C280", VA = "0x180A6CE80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001CB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000870")]
		[Address(RVA = "0xA6CDD0", Offset = "0xA6C1D0", VA = "0x180A6CDD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001CC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000871")]
		[Address(RVA = "0xA6CFD0", Offset = "0xA6C3D0", VA = "0x180A6CFD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001CD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TagStorageData TagStorageData
	{
		[Token(Token = "0x6000875")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000876")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6000872")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateTagStorageContentRequest()
	{
	}

	[Token(Token = "0x6000873")]
	[Address(RVA = "0xA6CD60", Offset = "0xA6C160", VA = "0x180A6CD60")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateTagStorageContentRequest(UpdateTagStorageContentRequest other)
	{
	}

	[Token(Token = "0x6000874")]
	[Address(RVA = "0xA6C980", Offset = "0xA6BD80", VA = "0x180A6C980", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateTagStorageContentRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000877")]
	[Address(RVA = "0xA6CA20", Offset = "0xA6BE20", VA = "0x180A6CA20", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000878")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(UpdateTagStorageContentRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000879")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600087A")]
	[Address(RVA = "0xA6CC00", Offset = "0xA6C000", VA = "0x180A6CC00", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600087B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600087C")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600087D")]
	[Address(RVA = "0xA6C8F0", Offset = "0xA6BCF0", VA = "0x180A6C8F0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600087E")]
	[Address(RVA = "0xA6CAD0", Offset = "0xA6BED0", VA = "0x180A6CAD0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UpdateTagStorageContentRequest other)
	{
	}

	[Token(Token = "0x600087F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000880")]
	[Address(RVA = "0xA6CED0", Offset = "0xA6C2D0", VA = "0x180A6CED0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
