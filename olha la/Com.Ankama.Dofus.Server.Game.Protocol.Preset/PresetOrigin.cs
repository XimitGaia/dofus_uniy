using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x20001DD")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PresetOrigin : IMessage<PresetOrigin>, IMessage, IEquatable<PresetOrigin>, IDeepCloneable<PresetOrigin>, IBufferMessage
{
	[Token(Token = "0x20001DE")]
	public enum OriginOneofCase
	{
		[Token(Token = "0x4000668")]
		None,
		[Token(Token = "0x4000669")]
		Empty,
		[Token(Token = "0x400066A")]
		Player,
		[Token(Token = "0x400066B")]
		Clone_
	}

	[Token(Token = "0x20001DF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x20001E0")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class EmptyPreset : IMessage<EmptyPreset>, IMessage, IEquatable<EmptyPreset>, IDeepCloneable<EmptyPreset>, IBufferMessage
		{
			[Token(Token = "0x400066C")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<EmptyPreset> _parser;

			[Token(Token = "0x400066D")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x1700041C")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<EmptyPreset> Parser
			{
				[Token(Token = "0x6001324")]
				[Address(RVA = "0xCDC510", Offset = "0xCDB910", VA = "0x180CDC510")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700041D")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6001325")]
				[Address(RVA = "0xCDC490", Offset = "0xCDB890", VA = "0x180CDC490")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700041E")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6001326")]
				[Address(RVA = "0xCDC560", Offset = "0xCDB960", VA = "0x180CDC560", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6001327")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public EmptyPreset()
			{
			}

			[Token(Token = "0x6001328")]
			[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public EmptyPreset(EmptyPreset other)
			{
			}

			[Token(Token = "0x6001329")]
			[Address(RVA = "0xCDC230", Offset = "0xCDB630", VA = "0x180CDC230", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public EmptyPreset Clone()
			{
				return null;
			}

			[Token(Token = "0x600132A")]
			[Address(RVA = "0xCDC2B0", Offset = "0xCDB6B0", VA = "0x180CDC2B0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x600132B")]
			[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(EmptyPreset other)
			{
				return default(bool);
			}

			[Token(Token = "0x600132C")]
			[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x600132D")]
			[Address(RVA = "0xCDC330", Offset = "0xCDB730", VA = "0x180CDC330", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x600132E")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x600132F")]
			[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6001330")]
			[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6001331")]
			[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(EmptyPreset other)
			{
			}

			[Token(Token = "0x6001332")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6001333")]
			[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x20001E2")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class PlayerCopy : IMessage<PlayerCopy>, IMessage, IEquatable<PlayerCopy>, IDeepCloneable<PlayerCopy>, IBufferMessage
		{
			[Token(Token = "0x400066F")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<PlayerCopy> _parser;

			[Token(Token = "0x4000670")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x1700041F")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<PlayerCopy> Parser
			{
				[Token(Token = "0x6001338")]
				[Address(RVA = "0xCE1970", Offset = "0xCE0D70", VA = "0x180CE1970")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000420")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6001339")]
				[Address(RVA = "0xCE18F0", Offset = "0xCE0CF0", VA = "0x180CE18F0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000421")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x600133A")]
				[Address(RVA = "0xCE19C0", Offset = "0xCE0DC0", VA = "0x180CE19C0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600133B")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public PlayerCopy()
			{
			}

			[Token(Token = "0x600133C")]
			[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public PlayerCopy(PlayerCopy other)
			{
			}

			[Token(Token = "0x600133D")]
			[Address(RVA = "0xCE1690", Offset = "0xCE0A90", VA = "0x180CE1690", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public PlayerCopy Clone()
			{
				return null;
			}

			[Token(Token = "0x600133E")]
			[Address(RVA = "0xCE1710", Offset = "0xCE0B10", VA = "0x180CE1710", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x600133F")]
			[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(PlayerCopy other)
			{
				return default(bool);
			}

			[Token(Token = "0x6001340")]
			[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6001341")]
			[Address(RVA = "0xCE1790", Offset = "0xCE0B90", VA = "0x180CE1790", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6001342")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6001343")]
			[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6001344")]
			[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6001345")]
			[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(PlayerCopy other)
			{
			}

			[Token(Token = "0x6001346")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6001347")]
			[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x20001E4")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class PresetClone : IMessage<PresetClone>, IMessage, IEquatable<PresetClone>, IDeepCloneable<PresetClone>, IBufferMessage
		{
			[Token(Token = "0x4000672")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<PresetClone> _parser;

			[Token(Token = "0x4000673")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4000674")]
			public const int PresetUuidToCloneFieldNumber = 1;

			[Token(Token = "0x4000675")]
			[FieldOffset(Offset = "0x18")]
			private string presetUuidToClone_;

			[Token(Token = "0x17000422")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<PresetClone> Parser
			{
				[Token(Token = "0x600134C")]
				[Address(RVA = "0xCE1FB0", Offset = "0xCE13B0", VA = "0x180CE1FB0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000423")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x600134D")]
				[Address(RVA = "0xCE1F30", Offset = "0xCE1330", VA = "0x180CE1F30")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000424")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x600134E")]
				[Address(RVA = "0xCE20C0", Offset = "0xCE14C0", VA = "0x180CE20C0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000425")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public string PresetUuidToClone
			{
				[Token(Token = "0x6001352")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
				[Token(Token = "0x6001353")]
				[Address(RVA = "0xCE2170", Offset = "0xCE1570", VA = "0x180CE2170")]
				set
				{
				}
			}

			[Token(Token = "0x600134F")]
			[Address(RVA = "0xCE1E40", Offset = "0xCE1240", VA = "0x180CE1E40")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public PresetClone()
			{
			}

			[Token(Token = "0x6001350")]
			[Address(RVA = "0xCE1E90", Offset = "0xCE1290", VA = "0x180CE1E90")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public PresetClone(PresetClone other)
			{
			}

			[Token(Token = "0x6001351")]
			[Address(RVA = "0xCE1B00", Offset = "0xCE0F00", VA = "0x180CE1B00", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public PresetClone Clone()
			{
				return null;
			}

			[Token(Token = "0x6001354")]
			[Address(RVA = "0xCE1BD0", Offset = "0xCE0FD0", VA = "0x180CE1BD0", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6001355")]
			[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(PresetClone other)
			{
				return default(bool);
			}

			[Token(Token = "0x6001356")]
			[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6001357")]
			[Address(RVA = "0xCE1CE0", Offset = "0xCE10E0", VA = "0x180CE1CE0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6001358")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6001359")]
			[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x600135A")]
			[Address(RVA = "0xCE1A70", Offset = "0xCE0E70", VA = "0x180CE1A70", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x600135B")]
			[Address(RVA = "0xCE1C80", Offset = "0xCE1080", VA = "0x180CE1C80", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(PresetClone other)
			{
			}

			[Token(Token = "0x600135C")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x600135D")]
			[Address(RVA = "0xCE2000", Offset = "0xCE1400", VA = "0x180CE2000", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4000660")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PresetOrigin> _parser;

	[Token(Token = "0x4000661")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000662")]
	public const int EmptyFieldNumber = 1;

	[Token(Token = "0x4000663")]
	public const int PlayerFieldNumber = 2;

	[Token(Token = "0x4000664")]
	public const int Clone_FieldNumber = 3;

	[Token(Token = "0x4000665")]
	[FieldOffset(Offset = "0x18")]
	private object origin_;

	[Token(Token = "0x4000666")]
	[FieldOffset(Offset = "0x20")]
	private OriginOneofCase originCase_;

	[Token(Token = "0x17000415")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PresetOrigin> Parser
	{
		[Token(Token = "0x600130B")]
		[Address(RVA = "0xCC5940", Offset = "0xCC4D40", VA = "0x180CC5940")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000416")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600130C")]
		[Address(RVA = "0xCC5830", Offset = "0xCC4C30", VA = "0x180CC5830")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000417")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600130D")]
		[Address(RVA = "0xCC5DA0", Offset = "0xCC51A0", VA = "0x180CC5DA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000418")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.EmptyPreset Empty
	{
		[Token(Token = "0x6001311")]
		[Address(RVA = "0xCC58E0", Offset = "0xCC4CE0", VA = "0x180CC58E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001312")]
		[Address(RVA = "0x917DA0", Offset = "0x9171A0", VA = "0x180917DA0")]
		set
		{
		}
	}

	[Token(Token = "0x17000419")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.PlayerCopy Player
	{
		[Token(Token = "0x6001313")]
		[Address(RVA = "0xCC5990", Offset = "0xCC4D90", VA = "0x180CC5990")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001314")]
		[Address(RVA = "0x917DE0", Offset = "0x9171E0", VA = "0x180917DE0")]
		set
		{
		}
	}

	[Token(Token = "0x1700041A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.PresetClone Clone_
	{
		[Token(Token = "0x6001315")]
		[Address(RVA = "0xCC57D0", Offset = "0xCC4BD0", VA = "0x180CC57D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001316")]
		[Address(RVA = "0x919620", Offset = "0x918A20", VA = "0x180919620")]
		set
		{
		}
	}

	[Token(Token = "0x1700041B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OriginOneofCase OriginCase
	{
		[Token(Token = "0x6001317")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(OriginOneofCase);
		}
	}

	[Token(Token = "0x600130E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetOrigin()
	{
	}

	[Token(Token = "0x600130F")]
	[Address(RVA = "0xCC55E0", Offset = "0xCC49E0", VA = "0x180CC55E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetOrigin(PresetOrigin other)
	{
	}

	[Token(Token = "0x6001310")]
	[Address(RVA = "0xCC4EC0", Offset = "0xCC42C0", VA = "0x180CC4EC0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetOrigin Clone()
	{
		return null;
	}

	[Token(Token = "0x6001318")]
	[Address(RVA = "0x916DD0", Offset = "0x9161D0", VA = "0x180916DD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearOrigin()
	{
	}

	[Token(Token = "0x6001319")]
	[Address(RVA = "0xCC5080", Offset = "0xCC4480", VA = "0x180CC5080", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600131A")]
	[Address(RVA = "0xCC4F20", Offset = "0xCC4320", VA = "0x180CC4F20", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PresetOrigin other)
	{
		return default(bool);
	}

	[Token(Token = "0x600131B")]
	[Address(RVA = "0xCC50E0", Offset = "0xCC44E0", VA = "0x180CC50E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600131C")]
	[Address(RVA = "0xCC5480", Offset = "0xCC4880", VA = "0x180CC5480", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600131D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600131E")]
	[Address(RVA = "0xCC5C20", Offset = "0xCC5020", VA = "0x180CC5C20", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600131F")]
	[Address(RVA = "0xCC4D10", Offset = "0xCC4110", VA = "0x180CC4D10", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001320")]
	[Address(RVA = "0xCC5280", Offset = "0xCC4680", VA = "0x180CC5280", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PresetOrigin other)
	{
	}

	[Token(Token = "0x6001321")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001322")]
	[Address(RVA = "0xCC59F0", Offset = "0xCC4DF0", VA = "0x180CC59F0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
