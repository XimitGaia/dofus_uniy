using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount;

[Token(Token = "0x2000311")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MountHarnessColorsUpdateRequest : IMessage<MountHarnessColorsUpdateRequest>, IMessage, IEquatable<MountHarnessColorsUpdateRequest>, IDeepCloneable<MountHarnessColorsUpdateRequest>, IBufferMessage
{
	[Token(Token = "0x4000AB3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MountHarnessColorsUpdateRequest> _parser;

	[Token(Token = "0x4000AB4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000AB5")]
	public const int UseHarnessColorsFieldNumber = 1;

	[Token(Token = "0x4000AB6")]
	[FieldOffset(Offset = "0x18")]
	private bool useHarnessColors_;

	[Token(Token = "0x170006D8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MountHarnessColorsUpdateRequest> Parser
	{
		[Token(Token = "0x6001FCD")]
		[Address(RVA = "0xD1D2A0", Offset = "0xD1C6A0", VA = "0x180D1D2A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006D9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001FCE")]
		[Address(RVA = "0xD1D1F0", Offset = "0xD1C5F0", VA = "0x180D1D1F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006DA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001FCF")]
		[Address(RVA = "0xD1D2F0", Offset = "0xD1C6F0", VA = "0x180D1D2F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006DB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool UseHarnessColors
	{
		[Token(Token = "0x6001FD3")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001FD4")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6001FD0")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountHarnessColorsUpdateRequest()
	{
	}

	[Token(Token = "0x6001FD1")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountHarnessColorsUpdateRequest(MountHarnessColorsUpdateRequest other)
	{
	}

	[Token(Token = "0x6001FD2")]
	[Address(RVA = "0xD1CEE0", Offset = "0xD1C2E0", VA = "0x180D1CEE0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountHarnessColorsUpdateRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001FD5")]
	[Address(RVA = "0xD1CF60", Offset = "0xD1C360", VA = "0x180D1CF60", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FD6")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MountHarnessColorsUpdateRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FD7")]
	[Address(RVA = "0xD1CFF0", Offset = "0xD1C3F0", VA = "0x180D1CFF0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001FD8")]
	[Address(RVA = "0xD1D090", Offset = "0xD1C490", VA = "0x180D1D090", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001FD9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001FDA")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001FDB")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001FDC")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MountHarnessColorsUpdateRequest other)
	{
	}

	[Token(Token = "0x6001FDD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001FDE")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
