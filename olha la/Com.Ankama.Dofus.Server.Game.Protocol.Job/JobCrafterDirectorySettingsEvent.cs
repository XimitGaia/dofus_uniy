using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job;

[Token(Token = "0x200035A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class JobCrafterDirectorySettingsEvent : IMessage<JobCrafterDirectorySettingsEvent>, IMessage, IEquatable<JobCrafterDirectorySettingsEvent>, IDeepCloneable<JobCrafterDirectorySettingsEvent>, IBufferMessage
{
	[Token(Token = "0x4000B86")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<JobCrafterDirectorySettingsEvent> _parser;

	[Token(Token = "0x4000B87")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000B88")]
	public const int SettingsFieldNumber = 1;

	[Token(Token = "0x4000B89")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<JobCrafterDirectorySettings> _repeated_settings_codec;

	[Token(Token = "0x4000B8A")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<JobCrafterDirectorySettings> settings_;

	[Token(Token = "0x1700076C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JobCrafterDirectorySettingsEvent> Parser
	{
		[Token(Token = "0x60022B0")]
		[Address(RVA = "0x96F8D0", Offset = "0x96ECD0", VA = "0x18096F8D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700076D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60022B1")]
		[Address(RVA = "0x96F820", Offset = "0x96EC20", VA = "0x18096F820")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700076E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60022B2")]
		[Address(RVA = "0x96FAE0", Offset = "0x96EEE0", VA = "0x18096FAE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700076F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JobCrafterDirectorySettings> Settings
	{
		[Token(Token = "0x60022B6")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60022B3")]
	[Address(RVA = "0x96F710", Offset = "0x96EB10", VA = "0x18096F710")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobCrafterDirectorySettingsEvent()
	{
	}

	[Token(Token = "0x60022B4")]
	[Address(RVA = "0x96F790", Offset = "0x96EB90", VA = "0x18096F790")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobCrafterDirectorySettingsEvent(JobCrafterDirectorySettingsEvent other)
	{
	}

	[Token(Token = "0x60022B5")]
	[Address(RVA = "0x96F260", Offset = "0x96E660", VA = "0x18096F260", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobCrafterDirectorySettingsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60022B7")]
	[Address(RVA = "0x96F320", Offset = "0x96E720", VA = "0x18096F320", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60022B8")]
	[Address(RVA = "0x96F400", Offset = "0x96E800", VA = "0x18096F400", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JobCrafterDirectorySettingsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60022B9")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60022BA")]
	[Address(RVA = "0x96F510", Offset = "0x96E910", VA = "0x18096F510", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60022BB")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60022BC")]
	[Address(RVA = "0x96FA30", Offset = "0x96EE30", VA = "0x18096FA30", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60022BD")]
	[Address(RVA = "0x96F1C0", Offset = "0x96E5C0", VA = "0x18096F1C0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60022BE")]
	[Address(RVA = "0x96F490", Offset = "0x96E890", VA = "0x18096F490", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JobCrafterDirectorySettingsEvent other)
	{
	}

	[Token(Token = "0x60022BF")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60022C0")]
	[Address(RVA = "0x96F920", Offset = "0x96ED20", VA = "0x18096F920", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
